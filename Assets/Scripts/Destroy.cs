using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	Vector3 originalCameraPosition;
	float shakeAmt = 0;
	public Camera mainCamera;

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Bubble")
		{
			Destroy(col.gameObject);
			shakeAmt = col.relativeVelocity.magnitude * .0025f;
			InvokeRepeating("CameraShake", 0, .01f);
			Invoke("StopShaking", 0.3f);
		}

		
	}
	void CameraShake()
		{
			if(shakeAmt>0)
			{
				float quakeAmt = Random.value*shakeAmt*2 - shakeAmt;
				Vector3 pp = mainCamera.transform.position;
				pp.y += quakeAmt; // Shakes Y of the camera
				pp.x += quakeAmt; //Shakes X of the camera
				mainCamera.transform.position = pp;
			}
		}

	void StopShaking()
	{
		CancelInvoke("CameraShake");
		originalCameraPosition.z = -10; // Keeps Z position on -10 in order to keep the main scene on screen
	}
}
