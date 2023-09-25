using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagment : MonoBehaviour
{
    public GameObject levelCompleteUI;
    public void CompleteLevel()
    {
        levelCompleteUI.SetActive(true);
    }
}
