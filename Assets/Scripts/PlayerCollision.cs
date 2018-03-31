using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    private Rigidbody Body;
    public GameObject DeathParticles;

    // Use this for initialization
    void Start () {
        Body = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Enemy")
        {
            Instantiate(DeathParticles, collision.transform.position, Quaternion.identity);
            Body.GetComponent<Spawn>().Respawn();
        }
    }
}
