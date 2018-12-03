using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class Destroy : MonoBehaviour {

	public AudioClip bottleShake;
	public GameObject Spawn1,Spawn2,Spawn3;
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Bubble")
		{
			Destroy(col.gameObject);
			CameraShaker.Instance.ShakeOnce(4f,4f,.1f,.1f);
			AudioSource.PlayClipAtPoint(bottleShake,new Vector3(5,1,2));	
			Spawn1.SetActive(true);
			Spawn2.SetActive(true);
			Spawn3.SetActive(true);
			GameObject.Find("GameManager").GetComponent<GameManager>().GameOver();

		}


	
	}

	


}
