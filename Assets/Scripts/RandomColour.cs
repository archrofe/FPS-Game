using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColour : MonoBehaviour
{
    public Material[] mats = null;
    public Renderer rend;

    // Use this for initialization
    void Start()
    {
        RandomMat();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void RandomMat()
    {
        int randomMatIndex = Random.Range(0, 3);
        rend = GetComponent<Renderer>();
        rend.material = mats[randomMatIndex];
    }
}
