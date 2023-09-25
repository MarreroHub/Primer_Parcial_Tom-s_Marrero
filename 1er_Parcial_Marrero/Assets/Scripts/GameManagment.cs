using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagment : MonoBehaviour
{
    public GameObject levelCompleteUI;
    public void CompleteLevel()
    {
        Time.timeScale = 0f;
        levelCompleteUI.SetActive(true);
    }
}
