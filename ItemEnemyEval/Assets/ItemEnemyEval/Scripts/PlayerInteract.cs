using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public PlayerHealth healthScript;
    public List<LinkProperty> propertyList;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("GoombaMov"))
        {
            healthScript.RemoveHealth(1);
        }
        if (collision.gameObject.CompareTag("GBullet"))
        {
            healthScript.RemoveHealth(2);
        }
        if (collision.gameObject.CompareTag("Key"))
        {
            //transfiero su property al player
            ItemLinkedScript script = collision.gameObject.GetComponent<ItemLinkedScript>();
            propertyList.Add(script.linked.property);
            collision.gameObject.SetActive(false);
        }
    }
}
