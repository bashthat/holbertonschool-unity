using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



public class Timer : MonoBehaviour
{
    

        public Text TimerText;
        private float startTime;
        public float t;

        void Start()
        {
            startTime = Time.time;


        }

        public void Win()
        {
            TimerText.color = Color.green;
            enabled = false;
        }
        void Update()
        {
            float t = Time.time - startTime;

            string minutes = ((int)t / 60).ToString();
            string seconds = (t % 60).ToString("f2");

            TimerText.text = minutes + ":" + seconds;

            
        }
    }