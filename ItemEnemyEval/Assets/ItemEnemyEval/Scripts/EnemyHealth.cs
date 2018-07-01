using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int totalHealth;
    public int currentHealth;

    private void Start()
    {
        currentHealth = totalHealth;
    }

    public void RemoveHealth()
    {
        currentHealth = currentHealth - 1;
        if(currentHealth==0)
        {
            if(transform.gameObject.CompareTag("GoombaMov"))
            {
                Destroy(gameObject.transform.parent.gameObject);
            }
            if (transform.gameObject.CompareTag("GoombaShoot") ||
                transform.gameObject.CompareTag("Chest"))
            {
                Destroy(gameObject);
            }
        }
    }
}
