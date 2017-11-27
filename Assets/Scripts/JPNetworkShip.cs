﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class JPNetworkShip : NetworkBehaviour {
	public bool forcePlayerNumber = false;
	public int playerNumber = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	[ClientRpc]
	public void RpcSetName (string name) {
		this.gameObject.name = name;
	}
}
