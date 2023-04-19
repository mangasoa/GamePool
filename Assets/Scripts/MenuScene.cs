using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScene : MonoBehaviour
{
    public void Play()
    {
        SceneBootManager.Instance.LoadScene("Game");
    }

    public void Quit()
    {
        SceneBootManager.Instance.QuitGame();
    }
}
