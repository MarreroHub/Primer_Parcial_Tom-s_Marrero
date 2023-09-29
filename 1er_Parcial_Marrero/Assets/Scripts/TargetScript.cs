using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetScript : MonoBehaviour
{
    public GameManagment gameManager;
    private void OnTriggerEnter()
    {
        SceneManager.LoadScene(4);
    }

}
