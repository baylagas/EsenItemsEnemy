using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public ItemLinkerScript linkerScript;
    public Text winText;
    public bool oneTime;

    private void Start()
    {
        SetWinText("");
    }

    private void Update()
    {
        if(linkerScript.GotLinkedItem && oneTime==false)
        {
            Debug.Log("You Win!!");
            SetWinText("You Win!!");
            StartCoroutine("ResetLevel");
            oneTime = true;
        }
    }

    public IEnumerator ResetLevel()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Main");
    }

    public void SetWinText(string message)
    {
        winText.text = message;
    }
}
