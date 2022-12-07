using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseTestFunction : MonoBehaviour
{
    public bool isPaused = false;
    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused == false)
            {
                Time.timeScale = 0;
                isPaused = true;
                Cursor.visible = true;
                pauseMenu.SetActive(true);
            }
            else
            {
                pauseMenu.SetActive(false);
                Cursor.visible = false;
                isPaused = false;
                Time.timeScale = 1;
            }
        }
        
            
    }
}
