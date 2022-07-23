using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;
using System;

public class TimerScript : MonoBehaviour
{

    public static float timer, seconds, minutes, hours;

    public TextMeshProUGUI currentTimeText;

    public static float currentTime;
    public static int startMinutes;
    public static TimeSpan time;

    public static bool start = true;

    public static bool stopwatch = true;
    

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        currentTime = startMinutes * 60;
        DontDestroyOnLoad(gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        stopwatchCalc();
        currentTime = currentTime + Time.deltaTime;
        time = TimeSpan.FromSeconds(currentTime);
        
        
    }

    public static void stopwatchCalc(){
        if(start){
            timer += Time.deltaTime;
            seconds = (int)(timer % 60);
            minutes = (int)(timer / 60);
            hours = (int)(timer / 3600);
            PlayerPrefs.SetFloat("timer", timer);
            PlayerPrefs.Save();
        }
        

    }

    public static void stopTimer(){
        start = false;
    }
    
}

