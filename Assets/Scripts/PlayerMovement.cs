using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private Vector3 input;
    public float maxSpeed = 10f;
    private Rigidbody Body;
    public GameObject DeathParticles;


    // Use this for initialization
    void Start()
    {
        print("imma cube yo");
        Body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var body = GetComponent<Rigidbody>();
        if (body.velocity.magnitude < maxSpeed)
        {
            input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
            Body.AddForce(input * moveSpeed);
        }

        if(Body.transform.position.y <= -2)
            Die();
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Enemy":
                Die();
                break;
            case "Goal":
                GameManager.CompleteLevel();
                break;


        }
    }

    void Die()
    {
        Instantiate(DeathParticles, Body.transform.position, Quaternion.identity);
        var spawn = Body.GetComponent<Spawn>();
        if (spawn == null)
        {
            Body.position = new Vector3(0, 0.5f, 0);
            return;
        }
        spawn.Respawn();


    }
}
