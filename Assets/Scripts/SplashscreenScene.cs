using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashscreenScene : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(ShowSplashScreen());
    }

    private IEnumerator ShowSplashScreen()
    {
        yield return new WaitForSeconds(3f);
        SceneBootManager.Instance.LoadScene("MenuScene");
    }

}
