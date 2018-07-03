using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public Text playerHealthText;

    private void Start()
    {
        currentHealth = maxHealth;
        SetPlayerHealthText();
    }

    private void SetPlayerHealthText()
    {
        playerHealthText.text = "PHealth: " + currentHealth;
    }

    public void AddHealth(int value)
    {
        currentHealth += value;
        if(currentHealth>maxHealth)
        {
            currentHealth = maxHealth;
        }
        SetPlayerHealthText();
    }

    public void RemoveHealth(int value)
    {
        currentHealth -= value;
        if (currentHealth <= 0)
        {
            //currentHealth = 0;
            RestartLevel();
        }
        SetPlayerHealthText();
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene("Main");
    }
}
