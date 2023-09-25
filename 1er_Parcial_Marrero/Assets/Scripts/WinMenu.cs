using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{

    public void PlayAgain()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("Exit Aplication");
        Application.Quit();
    }
}
