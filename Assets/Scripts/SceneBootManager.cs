using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneBootManager : MonoBehaviour
{
    private static SceneBootManager instance;

    public static SceneBootManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<SceneBootManager>();

                if (instance == null)
                {
                    GameObject go = new GameObject("SceneBootManager");
                    instance = go.AddComponent<SceneBootManager>();
                    DontDestroyOnLoad(go);
                }
            }

            return instance;
        }
    }

    private void Start()
    {
        LoadScene("Splashscreen");
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void UnloadScene(string sceneName)
    {
        SceneManager.UnloadSceneAsync(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
