using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

	public AudioClip boop;
	// Use this for initialization
	void Start () {
		enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		AudioSource.PlayClipAtPoint(boop,new Vector3(5,1,2));
		Destroy(gameObject);
		GameObject.Find("GameManager").GetComponent<ScoreManager>().AddScore();
	}



	
}
