using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {

	public GameObject coin, bomb;

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
			Debug.Log (whatToSpawn);

			switch(whatToSpawn){
				case 1:
				Instantiate(coin,transform.position,Quaternion.identity);
				break;
				case 2:
				Instantiate(bomb,transform.position,Quaternion.identity);
				break;
			}
			nextSpawn = Time.time + spawnRate;
		}
	}
}
