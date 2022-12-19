using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public bool GameIsPaused = false;
    public GameObject pauseCanvas;
    
    // Update is called once per frame
    
    
    public void Resume()
    {
        Time.timeScale = 1;
        pauseCanvas.SetActive(false);
        GameIsPaused = false;
        
    }

        public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Options()
    {
        SceneManager.LoadScene("OptionsMenu");
    }
    
    /**
    void OnEnable()
    {
        Pause();
    }
    */

    void Pause()
    {
        pauseCanvas.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;
        
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    void escape()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
        Debug.Log("The great escape");
        }
    }

    private void OnDisable()
    {
        Resume();
    }
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused == false)
            {
                Pause();
                Debug.Log("Paused");
            }
            else
            {
                Resume();
                Debug.Log("Resumed");

            }
        }
    }
}