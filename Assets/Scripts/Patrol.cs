using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {
    public Transform[] PatrolPoints;
    public float MoveSpeed;
    private int CurrentPoint;
    private Rigidbody Body;
    // Use this for initialization
    void Start () {
        transform.position = PatrolPoints[0].position;
        Body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        if (transform.position == PatrolPoints[CurrentPoint].position)
            CurrentPoint++;
        if (CurrentPoint >= PatrolPoints.Length)
            CurrentPoint = 0;

        transform.position = Vector3.MoveTowards(transform.position, PatrolPoints[CurrentPoint].position, MoveSpeed * Time.deltaTime);
	}
}
