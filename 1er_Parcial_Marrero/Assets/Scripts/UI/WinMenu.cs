using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{

    public void PlayAgain()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1f;
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Debug.Log("Exit Aplication");
        Application.Quit();
    }
}
