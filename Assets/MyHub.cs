using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyHub : NetworkManager {
    
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void MyStartHost()
    {
        Debug.Log("Starting host " + Time.timeSinceLevelLoad);
        StartHost();

    }

   public  override void OnStartHost()
    {
        Debug.Log("Host Start " + Time.timeSinceLevelLoad);
    }
}
