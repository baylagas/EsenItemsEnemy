using System;
using UnityEngine;

public class EnemyMovementSuper : MonoBehaviour
{
    public float speed;
    private Vector3 move;
    public GameObject upLimit;
    public GameObject downLimit;
    public GameObject leftLimit;
    public GameObject rightLimit;
    public bool vertical;

    private SpriteRenderer spRender;

    private void Awake()
    {
        spRender = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        if (vertical)
        {
            move = Vector3.up;
        }
        else
        {
            spRender.flipX = false;
            move = Vector3.left;
        }
    }

    private void FixedUpdate()
    {
        transform.position += move * speed;
        if (vertical)
        {
            CheckPositionY();
        }
        else
        {
            CheckPositionX();
        }
    }

    private void CheckPositionY()
    {
        if (transform.position.y > upLimit.transform.position.y)
        {
            move = Vector3.down;
        }
        if (transform.position.y < downLimit.transform.position.y)
        {
            move = Vector3.up;
        }
    }

    private void CheckPositionX()
    {
        if (transform.position.x < leftLimit.transform.position.x)
        {
            spRender.flipX = true;
            move = Vector3.right;
        }
        if (transform.position.x > rightLimit.transform.position.x)
        {
            spRender.flipX = false;
            move = Vector3.left;
        }
    }
}
