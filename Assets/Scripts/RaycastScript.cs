using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastScript : MonoBehaviour
{
    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction, Color.blue);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                //Debug.DrawRay(ray.origin, ray.direction, Color.blue);
                Debug.Log("Object clicked: " + hit.collider.gameObject.name);
            }
        }
    }
}
