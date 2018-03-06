using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject laserPoint;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit other;
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(Random.Range(.5f, .5f), Random.Range(.5f, .5f), 0));
            if (Physics.Raycast(ray, out other))
            {
                print(other.point);
                Instantiate(laserPoint, other.point, Quaternion.identity);
            }
        }
    }
}