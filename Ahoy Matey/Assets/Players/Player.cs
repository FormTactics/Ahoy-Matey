using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using System.Runtime.Remoting.Contexts;
using UnityEngine.Networking;

public class Player : NetworkBehaviour {

	private Vector3 inputValue;

	
	// Update is called once per frame
	void Update () {
		if (!isLocalPlayer)
		{
			return;
		}

		inputValue.x = CrossPlatformInputManager.GetAxis ("Horizontal");
		inputValue.y = 0f;
		inputValue.z = CrossPlatformInputManager.GetAxis ("Vertical");

		transform.Translate (inputValue);
	}

	override void OnStartLocalPlayer(){
//		if (!isLocalPlayer){ // Not needed.
//			return;
//		}

		GetComponentInChildren<Camera> ().enabled = true;

	}
}
