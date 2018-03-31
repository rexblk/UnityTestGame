using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
    public float DelayTime;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, DelayTime);
	}
}
