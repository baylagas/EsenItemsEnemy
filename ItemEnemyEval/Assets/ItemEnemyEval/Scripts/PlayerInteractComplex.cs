using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractComplex : MonoBehaviour
{
    public List<LinkProperty> propertyArray;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("GoldKey"))
        {
            //transfiero su property al player
            ItemLinkedScript script = collision.gameObject.GetComponent<ItemLinkedScript>();
            propertyArray.Add(script.linked.property);
            collision.gameObject.SetActive(false);
        }
    }
}
