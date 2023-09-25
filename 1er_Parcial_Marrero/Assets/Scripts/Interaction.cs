using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interaction : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
        PauseMenu.GameIsPaused = false;
    }
}
