using UnityEngine;

public class EnemyInteract : MonoBehaviour
{
    private EnemyHealth health;

    private void Awake()
    {
        health = GetComponent<EnemyHealth>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            health.RemoveHealth();
        }
    }
}
