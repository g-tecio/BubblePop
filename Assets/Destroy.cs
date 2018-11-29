using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Bomb")
		{
			Destroy(col.gameObject);
		}

		if(col.gameObject.tag == "Coin")
		{
			Destroy(col.gameObject);
		}
	}
}
