using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //variables de instancia
    public float speed;
    Vector3 move;
    private SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    public int direction;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");
        CheckSprite(horizontalMove, verticalMove);
        move = new Vector3(horizontalMove, verticalMove, 0.0f);
    }

    private void CheckSprite(float pXMove, float pYMove)
    {
        if (pXMove > 0)
        {
            spriteRenderer.sprite = spriteArray[2];
            direction = 1;
        }
        else if (pXMove < 0)
        {
            spriteRenderer.sprite = spriteArray[1];
            direction = 3;
        }
        else if (pYMove > 0)
        {
            spriteRenderer.sprite = spriteArray[3];
            direction = 0;
        }
        else if (pYMove < 0)
        {
            spriteRenderer.sprite = spriteArray[0];
            direction = 2;
        }
    }

    private void FixedUpdate()
    {
        transform.position += move * speed;
    }
}
