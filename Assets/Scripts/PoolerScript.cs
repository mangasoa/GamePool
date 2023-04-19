using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolerScript: MonoBehaviour
{
    public GameObject prefab;
    public int poolSize = 10;

    private GameObject[] pool;

    private void Awake()
    {
        pool = new GameObject[poolSize];
        for (int i = 0; i < poolSize; i++)
        {
            pool[i] = Instantiate(prefab, transform.position, Quaternion.identity);
            pool[i].SetActive(false);
        }
    }

    public GameObject GetObjectFromPool()
    {
        for (int i = 0; i < poolSize; i++)
        {
            if (!pool[i].activeInHierarchy)
            {
                return pool[i];
            }
        }

        return null;
    }

    public void ReturnObjectToPool(GameObject obj)
    {
        obj.SetActive(false);
    }
}
