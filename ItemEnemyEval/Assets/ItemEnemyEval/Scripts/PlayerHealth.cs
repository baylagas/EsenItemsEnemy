using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void RemoveHealth(int value)
    {
        currentHealth -= value;
        if (currentHealth <= 0)
        {
            //currentHealth = 0;
            RestartLevel();
        }
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene("Main");
    }
}
