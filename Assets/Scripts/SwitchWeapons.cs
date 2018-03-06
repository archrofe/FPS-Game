using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeapons : MonoBehaviour
{
    public GameObject gun;
    public GameObject scanner;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            scanner.SetActive(true);
            gun.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            gun.SetActive(true);
            scanner.SetActive(false);
        }
    }
}
