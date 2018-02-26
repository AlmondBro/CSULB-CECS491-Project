using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Selection : MonoBehaviour {

    protected List<GameObject> listOfHumanPlayers;
    protected Field_of_Vision fov = new Field_of_Vision();

    int playerIterator;
    GameObject selectedPlayer; //the player the AI attacks
    float damping = 60;
    float maxDistance;

    // Use this for initialization
    void Start()
    {

        playerIterator = 0;
        listOfHumanPlayers = new List<GameObject>();

    }

    // Update is called once per frame
    void Update()
    {

        //If the array of game objects in not empty
        if (listOfHumanPlayers.Count != 0)
        {

            if (listOfHumanPlayers[playerIterator] == null)
            {
                listOfHumanPlayers.Remove(listOfHumanPlayers[playerIterator]);
                MonoBehaviour.print("I am removing this object from my list");
            }
            if (listOfHumanPlayers.Count != 0)
            {
                Debug.Log("Target Sighted");
                selectedPlayer = listOfHumanPlayers[playerIterator];
                //Distance between player and ai         
                Vector3 playerDistance = selectedPlayer.transform.position - transform.position;
                //have ai face the human player before proceeding with the attack         
                float angle = (Mathf.Atan2(playerDistance.y, playerDistance.x) * Mathf.Rad2Deg) - 90;
                Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, Time.deltaTime * damping);

            }
        }

        UpdateList();
    }

    void UpdateList()
    {
        GameObject target = fov.addNewTarget();
        if (!listOfHumanPlayers.Contains(target))
        {
            listOfHumanPlayers.Add(target);
        }
    }
}
