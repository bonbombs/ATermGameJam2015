﻿using UnityEngine;
using System.Collections;

public class RotateBone : MonoBehaviour {

    public float speed = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.forward * speed);
	}
}
