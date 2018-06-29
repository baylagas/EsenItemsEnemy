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
            Destroy(gameObject);
        }
    }
}
