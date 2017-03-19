using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

public class Player : NetworkBehaviour {

	private Vector3 inputValue;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		// doublecheck that we only move the player object when it's the local player
		// DO NO NOT MOVE ALL PLAYERS!
		if (isLocalPlayer == false) {
			return;
		}


		// set the V3 so we can move things around.
		inputValue.x = CrossPlatformInputManager.GetAxis ("Horizontal");
		inputValue.y = 0f;
		inputValue.z = CrossPlatformInputManager.GetAxis ("Vertical");

		transform.Translate (inputValue);



	}





}
