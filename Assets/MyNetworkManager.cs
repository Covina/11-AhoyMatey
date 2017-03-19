using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {


	// Use this for initialization
	void Start ()
	{


	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}


	public void MyStartHost ()
	{
		Debug.Log("[" + Time.timeSinceLevelLoad + "] Starting Host.");
		StartHost();

	}


	public override void OnStartHost()
	{
		Debug.Log("[" + Time.timeSinceLevelLoad + "] Host Started.");

	}


	public override void OnStartClient (NetworkClient myClient)
	{

		// method is called when client is started
		Debug.Log("[" + Time.timeSinceLevelLoad + "] Client start requested");
	}


	public override void OnClientConnect(NetworkConnection myConn) 
	{
		// method is called when client is started
		Debug.Log("[" + Time.timeSinceLevelLoad + "] Client is now connected to IP Address: " + myConn.address);

	}


}
