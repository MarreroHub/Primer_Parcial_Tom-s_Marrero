using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1f;
        PauseMenu.GameIsPaused = false;
    }

    public void DemostrationScene()

    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
        PauseMenu.GameIsPaused = false;
    }

    public void QuitGame()
    {
        Debug.Log("Exit Aplication");
        Application.Quit();

    }


    public void Credits()
    {
        SceneManager.LoadScene(0);

    }
}
