using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class GameManager : MonoBehaviour {

	public GameObject gameOverPanel, heart1, heart2, heart3, Bspawn1, Bspawn2, Bspawn3, Sspawn1, Sspawn2, Sspawn3, prefab1,prefab2;
	public void Restart(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		
	}

	public static int health;
	void Start () {
		health = 3;
		heart1.gameObject.SetActive(true);
		heart2.gameObject.SetActive(true);
		heart3.gameObject.SetActive(true);
		gameOverPanel.gameObject.SetActive(false);
		Bspawn1.gameObject.SetActive(true);
		Bspawn2.gameObject.SetActive(true);
		Bspawn3.gameObject.SetActive(true);
		Sspawn1.gameObject.SetActive(false);
		Sspawn2.gameObject.SetActive(false);
		Sspawn3.gameObject.SetActive(false);
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if(health > 3)
		health = 3;

		switch(health){
			case 3:
			heart1.gameObject.SetActive(true);
			heart2.gameObject.SetActive(true);
			heart3.gameObject.SetActive(true);
			Bspawn1.gameObject.SetActive(true);
			Bspawn2.gameObject.SetActive(true);
			Bspawn3.gameObject.SetActive(true);
			Sspawn1.gameObject.SetActive(false);
			Sspawn2.gameObject.SetActive(false);
			Sspawn3.gameObject.SetActive(false);
			break;
			case 2:
			heart1.gameObject.SetActive(true);
			heart2.gameObject.SetActive(true);
			heart3.gameObject.SetActive(false);
			Bspawn1.gameObject.SetActive(true);
			Bspawn2.gameObject.SetActive(true);
			Bspawn3.gameObject.SetActive(true);
			Sspawn1.gameObject.SetActive(true);
			Sspawn2.gameObject.SetActive(false);
			Sspawn3.gameObject.SetActive(false);
			break;
			case 1:
			heart1.gameObject.SetActive(true);
			heart2.gameObject.SetActive(false);
			heart3.gameObject.SetActive(false);
			Bspawn1.gameObject.SetActive(true);
			Bspawn2.gameObject.SetActive(true);
			Bspawn3.gameObject.SetActive(true);
			Sspawn1.gameObject.SetActive(true);
			Sspawn2.gameObject.SetActive(true);
			Sspawn3.gameObject.SetActive(true);
			break;
			case 0:
			heart1.gameObject.SetActive(false);
			heart2.gameObject.SetActive(false);
			heart3.gameObject.SetActive(false);
			Bspawn1.gameObject.SetActive(false);
			Bspawn2.gameObject.SetActive(false);
			Bspawn3.gameObject.SetActive(false);
			Sspawn1.gameObject.SetActive(false);
			Sspawn2.gameObject.SetActive(false);
			Sspawn3.gameObject.SetActive(false);
			

			gameOverPanel.gameObject.SetActive(true);
			
			Time.timeScale = 1;
			break;
			
		}
	}

}
