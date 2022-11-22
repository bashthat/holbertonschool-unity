using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    
    public void Pause()
    {
        Time.timeScale = 0;
    }
    
    public void Resume()
    {
        Time.timeScale = 1;
    }
    
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void Quit()
    {
        Application.Quit();
    }


}