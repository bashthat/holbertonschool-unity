using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



public class Timer : MonoBehaviour
{
    public int playtime = 0;
    private int seconds = 0;
    private int minutes = 0;
    private int hours = 0;
    private int days = 0;
    public Text TimerText;
    private float timer = 0.0f;
    private bool timerRunning = true;
    public Text startTime;
    private Stopwatch stopWatch = new Stopwatch();

    void Start()
    {
        stopWatch.Start();
        // StartCoroutine(Playtime());
    }

    //private IEnumerator Playtime()
    //{
        //while (true)
        //{
            //yield return new WaitForSeconds(1);
            //playtime++;
            //seconds = playtime % 60;
            //minutes = (playtime / 60) % 60;
            //hours = (playtime / 3600) % 24;
            //days = (playtime / 86400) % 365;
            //TimerText.text = days.ToString("00") + ":" + hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");
        //}
        //void OnGUI()
        //{
            //if(GUI.Button(new Rect(100, 100, 40, 40), "Reset"))
            //{
                //playtime = 0;
            //}

            //GUI.Label(new Rect(50, 50, 400, 50), "Time: " + TimerText);
        //}
    

    void Update()
    {
        // timer += Time.deltaTime;
        TimerText.text = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);

        // TimerText.text = stopWatch.Elapsed.ToString("hh\\:mm\\:ss");

        
    }
    public void ResetTimer()
    {
        stopWatch.Reset();
        stopWatch.Start();
        
    }
}