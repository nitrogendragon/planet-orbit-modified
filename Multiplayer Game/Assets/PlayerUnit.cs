﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
// A playerUnit is a unit controlled by a player
//could be character in FPS, zergling in a RTS
//Or a scout in a TBS

public class PlayerUnit : NetworkBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //this function runs on ALL PlayerUnits -- not just the ones that I own.
        //How do I verify that I am allowed to mess with this object?
       // if (isLocalPlayer == false)
        if(hasAuthority == false)
        {
            return;
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.transform.Translate(0, 1, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Destroy(gameObject);
        }
    }
}
