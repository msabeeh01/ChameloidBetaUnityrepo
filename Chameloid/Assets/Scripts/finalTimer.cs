using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class finalTimer : MonoBehaviour
{
    public TextMeshProUGUI currentTimeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTimeText.text =  TimerScript.hours.ToString("00") + ":" + TimerScript.minutes.ToString("00") + ":" + TimerScript.seconds.ToString("00");
        TimerScript.stopTimer();
    }
}
