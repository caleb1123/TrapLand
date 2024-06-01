using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour
{
    public Text timeCounter;

    private float currentTime;

    private bool finished = false; 

    private void Start()
    {
        timeCounter.text = "Time: 00:00.00";
        currentTime = Time.time;
    }

    void Update()
    {
        if (finished)
            return;
        float t = Time.time - currentTime;
        string minutes = ((int)t / 60).ToString();
        string seconds =(t % 60).ToString("f2");
        if(int.Parse(minutes) <10){
          timeCounter.text = "Time: 0" + minutes + ":" + seconds;
        }else{
              timeCounter.text = "Time: " + minutes + ":" + seconds;
        }
       
    }

    public void Finnish()
    {
        finished = true;
    }

}

