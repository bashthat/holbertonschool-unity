using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public bool GameIsPaused = false;
    public GameObject pauseCanvas;
    public PauseMenu pauseMenu;
    // Update is called once per frame
    
    
    void Resume()
    {
        Time.timeScale = 1;
        pauseCanvas.SetActive(false);
        
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
    
    void OnEnable()
    {
        Pause();
    }

    void Pause()
    {
        pauseCanvas.SetActive(true);
        
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
    void Start()
    {
        pauseCanvas.SetActive(false);
        Debug.Log("Pause Menu Loaded");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
}