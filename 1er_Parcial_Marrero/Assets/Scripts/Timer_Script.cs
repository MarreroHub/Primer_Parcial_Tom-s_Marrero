using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer_Script : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    public GameObject GameOverUI;

    void Update()
    {

        if (remainingTime > 0)
        { remainingTime -= Time.deltaTime; }

        else if (remainingTime <= 0)
        { remainingTime = 0; }

        remainingTime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (remainingTime < 0)
        {
            if (GameOverUI)
            { }
        }

    }
}
