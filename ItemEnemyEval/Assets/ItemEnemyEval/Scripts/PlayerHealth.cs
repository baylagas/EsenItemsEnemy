using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void AddHealth(int value)
    {
        currentHealth += value;
        if(currentHealth>maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}
