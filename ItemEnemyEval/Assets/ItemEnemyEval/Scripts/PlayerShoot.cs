using UnityEngine;
using System.Collections;
using System;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet;

    void Awake()
    {
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        { 
            CanShoot();
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            CanShoot();
        }
    }

    private void CanShoot()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
