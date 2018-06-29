using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public PlayerHealth healthScript;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Potion"))
        {
            healthScript.AddHealth(2);
            Destroy(collision.gameObject);
        }
    }
}
