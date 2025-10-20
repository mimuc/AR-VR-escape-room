using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour
{
    public float countdown;

    public bool countdownStopped = false;

    public TMP_Text timeText;

    public GameObject failUI;
    public GameObject winUI;

    [SerializeField] TimerScript ts;

    // Update is called once per frame
    void Update()
    {
        if(countdown > 0 && countdownStopped == false)
        {
            countdown -= Time.deltaTime;
        }
        else if (countdown > 0 && countdownStopped == true)
        {
            timeText.text = countdown.ToString();
            timeText.color = Color.green;
            winUI.SetActive(true);
        }
        else
        {
            countdown = 0;
        }

        DisplayTime(countdown);
    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0) 
        { 
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);

        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (timeToDisplay == 0 && countdownStopped == false && ts.gameWon == false)
        {
            Debug.Log("Game failed");
            timeText.color = Color.red;
            countdownStopped = true;
            failUI.SetActive(true);
        }
    }
}
