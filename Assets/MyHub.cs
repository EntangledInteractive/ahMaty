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
        Debug.Log(Time.timeSinceLevelLoad+" Starting host. "  );
        StartHost();

    }

   public  override void OnStartHost()
    {
        Debug.Log( Time.timeSinceLevelLoad+" Host Start. ");
    }
    public override void OnStartClient(NetworkClient myClient)
    {
        Debug.Log(Time.timeSinceLevelLoad + " Client Start rerquested. ");
        InvokeRepeating("printdot",0f, 1f);
    }
    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log(Time.timeSinceLevelLoad + " Client id connect to IP: "+ conn.address);
        CancelInvoke();
    }
    void printdot()
    {
        Debug.Log(".");
    }
}
