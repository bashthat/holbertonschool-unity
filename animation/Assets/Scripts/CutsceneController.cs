using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CutsceneController : MonoBehaviour
{
    // enable Main Camera
    // enable PlayerController
    // enable TimerCanvas
    // disable CutsceneController

    public GameObject mainCamera;
    public GameObject playerController;
    public GameObject timerCanvas;
    public GameObject cutsceneController;

    public void Start()
    {
        
        mainCamera.SetActive(false);
        playerController.SetActive(false);
        timerCanvas.SetActive(false);
        cutsceneController.SetActive(true);


    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mainCamera.SetActive(true);
            playerController.SetActive(true);
            timerCanvas.SetActive(true);
            cutsceneController.SetActive(false);
        }
    }
    

}

// Path: PlayerController.cs