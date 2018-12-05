using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour {

	public Image splashImage;

    IEnumerator Start()
    {
        splashImage.canvasRenderer.SetAlpha(0.0f);

        FadeIn();
        yield return new WaitForSecondsRealtime(2.5f);
        Fadeout();
        yield return new WaitForSecondsRealtime(2.5f);
        SceneManager.LoadScene("GameScene");
    }

    void FadeIn()
    {
        splashImage.CrossFadeAlpha(1.0f, 1.5f, false);
    }

    void Fadeout()
    {
        splashImage.CrossFadeAlpha(0.0f, 2.5f, false);
    }
}
