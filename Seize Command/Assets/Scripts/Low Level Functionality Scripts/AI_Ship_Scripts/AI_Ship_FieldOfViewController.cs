using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

/// <summary>
/// Keeps track of all the enemies inside of the ships field of view
/// </summary>
public class AI_Ship_FieldOfViewController : MonoBehaviour
{
    // List of all the enemies
    public List<GameObject> enemies { get; private set; }

    // This script is the decision tree which enables and disables scripts
    // This is important here because we need to let it know we have seen an enemy
    AI_Ship_DecisionTree decTree;

    // Initialization
    void Start()
    {
        decTree = GetComponentInParent<AI_Ship_DecisionTree>();
        enemies = new List<GameObject>();
    }

    /// <summary>
    /// Adds Enemies to the list when they enter
    /// </summary>
    /// <param name="coll"></param>
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.CompareTag("Player"))
        {
            if (enemies.Count == 0) decTree.State = AI_Ship_DecisionTree.AIState.Attack;

            enemies.Add(coll.gameObject);
            Debug.Log("I see You");
        }
    }

    /// <summary>
    /// Removes Enemies from the list when they leave
    /// </summary>
    /// <param name="coll"></param>
    void OnTriggerExit2D(Collider2D coll)
    {
        if(enemies.Contains(coll.gameObject))
        {
            enemies.Remove(coll.gameObject);

            // Only sets Patrol in the decision tree when there are no enemies left
            if(enemies.Count == 0) decTree.State = AI_Ship_DecisionTree.AIState.Patrol;

            Debug.Log("I don't see You");
        }
    }
}
