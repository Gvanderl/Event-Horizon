﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class JPNetworkPlayer : NetworkBehaviour {
	GameObject selectedShip;
	GameObject targetShip;
	Vector3 targetPosition;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	[Command]
	public void CmdSelectShip (string shipName) {
		selectedShip = GameObject.Find (shipName);
		print("Ship name recieved by server" + shipName);
	}
	[Command]
	public void CmdSetTargetShip (string shipName) {
		targetShip = GameObject.Find (shipName);
		//selectedShip.GetComponent<OPShipMovement>().setTargetShip(targetShip);
		print("Insert code to set target here");
	}
	[Command]
	public void CmdSetPosition (Vector3 pos) {
		targetPosition = pos;
		//selectedShip.GetComponent<OPShipMovement>().setTargetPosition(pos);
		print("Insert code to set position here");
	}
}
