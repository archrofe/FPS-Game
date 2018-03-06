using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullets : MonoBehaviour
{
    public float destroyTimer = 1;

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, destroyTimer);
    }
}