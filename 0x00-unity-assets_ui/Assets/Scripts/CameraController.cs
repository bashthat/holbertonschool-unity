using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CamraOptionsMenu : MonoBehaviour
{
    public void Apply()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public bool isInverted = false;   
}