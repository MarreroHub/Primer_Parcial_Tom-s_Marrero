using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public GameManagment gameManager;
    private void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }

}
