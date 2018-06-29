using UnityEngine;

public class BulletInteract : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("i am bullet and i hit the enemy");
            Destroy(gameObject);
        }
    }
}
