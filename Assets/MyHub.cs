using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyHub : MonoBehaviour {
    private NetworkManager netManger;
	// Use this for initialization
	void Start () {
        netManger = GetComponent<NetworkManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void MyStartHost()
    {
        Debug.Log("Starting host " + Time.timeSinceLevelLoad);
        netManger.StartHost();

    }

    void OnStartHost()
    {
        Debug.Log("Host Start " + Time.timeSinceLevelLoad);
    }
}
