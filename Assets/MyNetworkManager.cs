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
		Debug.Log("Starting Host at: " + Time.timeSinceLevelLoad);
		StartHost();

	}


	public override void OnStartHost()
	{
		Debug.Log("Host Started at: " + Time.timeSinceLevelLoad);

	}


}
