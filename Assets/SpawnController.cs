using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {

	public GameObject spawn1,spawn2,spawn3;
	public static bool disabled = false;

	// Use this for initialization
	void Start () {
		enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(disabled)
		{
			spawn1.SetActive(false);
			spawn2.SetActive(false);
			spawn3.SetActive(false);
		}else{
			spawn1.SetActive(true);
			spawn2.SetActive(true);
			spawn3.SetActive(true);
		}
		
	}
}
