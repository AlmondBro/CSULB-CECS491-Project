using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.Match;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CustomNetworkManager : NetworkManager {

	public MatchInfoSnapshot targetMatch;
	public GameObject scrollView;
	public GameObject activeGamePrefab;
	bool notHost = false;

	// Use this for initialization
	void Start () {
		StartMatchMaker();
		matchMaker.ListMatches(0, 10, "", true, 0, 0, OnMatchList);
	}

	public void OnMatchList(bool success, string extendedInfo, List<MatchInfoSnapshot> matches)
    {

		
        if(matches.Count != 0)
		{
			foreach(MatchInfoSnapshot match in matches)
			{
			var copy = Instantiate(activeGamePrefab);
			copy.GetComponent<gameChoose>().match = match;
			copy.transform.GetChild(0).GetComponentInChildren<Text>().text = match.name;
			GameObject content = scrollView.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
			copy.transform.parent = content.transform;
			copy.transform.localPosition = Vector3.zero;
			}
		}
        
    }
	public void BeginGame()
	{
		StartHost();
		matchMaker.CreateMatch("roomName", 4, true, "", "", "", 0, 0, OnMatchCreate);
	}

	public void JoinGame()
	{
		matchMaker.JoinMatch(targetMatch.networkId,"","","",0,0,OnMatchJoined);
	}

	public override void OnMatchCreate(bool success, string extendedInfo, UnityEngine.Networking.Match.MatchInfo matchInfo)
	{
		Debug.Log("wew");
		ServerChangeScene("Alex_Network1");
	}

	public override void OnMatchJoined(bool success, string extendedInfo, MatchInfo matchInfoData)
	{
		if (success)
     {
         Debug.Log("Able to join a match");
		 singleton.StartClient();
		 
     }
     else
     {
         Debug.LogError("Join match failed");
     }
	}

	public override void OnServerSceneChanged(string sceneName)
	{
		GameObject mShip = Instantiate<GameObject>(spawnPrefabs[0]);
		mShip.transform.position = Vector2.zero;
		NetworkServer.Spawn(mShip);
	}

	public override void OnClientConnect(NetworkConnection conn)
	{
		//base.OnClientConnect(conn);
	}

	public override void OnClientSceneChanged(NetworkConnection conn)
	{
		ClientScene.Ready(conn);
		GameObject playerObj = GameObject.Instantiate(playerPrefab);
		ClientScene.AddPlayer(conn,0);
	}

	
	// Update is called once per frame
	void Update () {
		
	}

}
