using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public PoolerScript poolerScript;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj = poolerScript.GetObjectFromPool();
            if (obj != null)
            {
                obj.SetActive(true);
                obj.transform.position = new Vector3(Random.Range(-6f, 6f), 0f, Random.Range(-6f, 6f));
                //obj.transform.position = new Vector3(Random.Range(-100f, 100f), 0f, Random.Range(-100f, 100f));
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MenuScene");
        }
    }
}
