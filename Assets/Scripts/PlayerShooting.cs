﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

	// Use this for initialization
	public GameObject prefab;
	public Transform head;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown (0)) {
			GameObject.Instantiate(prefab, head.position, head.rotation);
		}
	}
}
