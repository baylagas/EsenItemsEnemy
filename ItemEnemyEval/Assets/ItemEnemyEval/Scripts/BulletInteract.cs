using UnityEngine;

public class BulletInteract : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("GoombaMov"))
        {
            Destroy(gameObject);
        }
    }
}
