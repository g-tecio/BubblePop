﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {

	public GameObject bubble;

	public float spawnRate = 2f;

	float nextSpawn = 0f;

	int whatToSpawn;
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > nextSpawn){
			whatToSpawn = Random.Range(1,3);
			

			switch(whatToSpawn){
				case 1:
				Instantiate(bubble,transform.position,Quaternion.identity);
				break;
			}
			nextSpawn = Time.time + spawnRate;
		}
	}
}
