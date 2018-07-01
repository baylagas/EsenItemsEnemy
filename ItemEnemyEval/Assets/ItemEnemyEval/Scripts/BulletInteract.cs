using UnityEngine;

public class BulletInteract : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("GoombaMov"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("GoombaShoot"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Chest"))
        {
            Destroy(gameObject);
        }

    }
}
