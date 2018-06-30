using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMovement : MonoBehaviour
{
    public float speed;
    Vector3 move;
    public int direction;
    public Sprite[] spriteArray;
    SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        CheckDirection();
    }

    void Start()
    {
        StartCoroutine(DestroyBullet());
    }

    private IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(2f);
        Destroy(transform.gameObject);
    }

    private void CheckDirection()
    {
        if (direction == 0)
        {
            move = Vector3.up;
            spriteRenderer.sprite = spriteArray[1];
        }
        else if (direction == 1)
        {
            move = Vector3.right;
            spriteRenderer.sprite = spriteArray[0];
        }
        else if (direction == 2)
        {
            move = Vector3.down;
            spriteRenderer.sprite = spriteArray[1];
        }
        else if (direction == 3)
        {
            move = Vector3.left;
            spriteRenderer.sprite = spriteArray[0];
        }
    }

    void FixedUpdate()
    {
        transform.position += move * speed;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            //Debug.Log("Collided with wall!!");
            DestroyAnimation();
            Destroy(transform.gameObject);
        }
        else if (other.gameObject.CompareTag("Pot"))
        {
            //Debug.Log("Collided with pot!!");
            DestroyAnimation();
            Destroy(transform.gameObject);
        }
        else if (other.gameObject.CompareTag("Enemy01"))
        {
            //Debug.Log("Collided with Enemy01!!");
            DestroyAnimation();
            Destroy(transform.gameObject);
        }
        else if (other.gameObject.CompareTag("Enemy02"))
        {
            //Debug.Log("Collided with Enemy01!!");
            DestroyAnimation();
            Destroy(transform.gameObject);
        }
    }

    private void DestroyAnimation()
    {
    }
}
