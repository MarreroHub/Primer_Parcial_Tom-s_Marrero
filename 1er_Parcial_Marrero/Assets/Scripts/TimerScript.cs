using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    public float timerCount;
    public static bool GameIsOver = false;
    public GameObject GameOverMenu;


    void Update()
    {
        timerCount -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(timerCount / 60);
        int seconds = Mathf.FloorToInt(timerCount % 60);
        timerText.text = string.Format("{00:00} : {01:00}", minutes, seconds);

        if (timerCount < 1)
        {
            timerCount = 0;
        }

        if (timerCount <= 0)
        {
            GameOverMenu.SetActive(true);
            Time.timeScale = 0f;
            GameIsOver = true;
        }

        else if (timerCount >= 0)
        {
            GameOverMenu.SetActive(false);
            GameIsOver = false;
            Time.timeScale = 1f;
        }

        if (PauseMenu.GameIsPaused == true)
        {
            Time.timeScale = 0f;
        }

    }
}
