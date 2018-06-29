using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLinkerScript : MonoBehaviour
{
    public ItemLinker linker;
    private SpriteRenderer spRender;

    private void Awake()
    {
        spRender = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            PlayerInteractComplex playerScript = 
                collision.gameObject.GetComponent<PlayerInteractComplex>();
            List<ItemLinked> linkedArray = linker.linkedArray;

            List<LinkProperty> playerPropArray = playerScript.propertyArray;

            foreach (var item in linkedArray)
            {
                if(playerPropArray.Contains(item.property))
                {
                    Debug.Log(item.linkedName);
                    Debug.Log(item.property.isObtained);
                    Debug.Log("player has item");
                    ChangeToSprite();
                }
                else
                {
                    Debug.Log("player does not have item");
                }
            }
        }
    }

    private void ChangeToSprite()
    {
        spRender.sprite = linker.changeToSprite;
    }
}
