﻿using UnityEngine;
using System.Collections;

public class CubeMove : MonoBehaviour {

	public float moveSpeed;

	// Use this for initialization
	void Start () 
	{
		moveSpeed = 1f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//print ();
		transform.Translate (moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime,0f);
	}
}
