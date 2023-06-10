using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public float time=0;
    public bool timerIsRunning = false;
    public Text timeText;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }
    void Update()
    {
        if (timerIsRunning)
        {
           
                time += Time.deltaTime;
                DisplayTime(time);
            }
            if(time>90){
                star3.SetActive(false);
            }
            if(time>150){
                star2.SetActive(false);
            }
            if(time>300){
                star1.SetActive(false);
            }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}