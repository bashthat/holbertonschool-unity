using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    
    
    void Resume()
    {
        Time.timeScale = 1;
        pauseMenuUI.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
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
        Time.timeScale = 0;
        pauseMenuUI.SetActive(true);
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
        pauseMenuUI.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Going Fishing");
            pauseMenuUI.SetActive(!pauseMenuUI.gameObject.activeSelf);
        }
    }
}