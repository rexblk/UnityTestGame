using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    public Transform SpawnPoint;

    private Rigidbody Body;
    // Use this for initialization
    void Start () {
        Body = GetComponent<Rigidbody>();
        Body.position = SpawnPoint.position;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Respawn()
    {
        Body.position = SpawnPoint.position;
    }

}
