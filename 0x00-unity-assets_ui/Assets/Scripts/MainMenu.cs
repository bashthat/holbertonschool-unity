using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour

{
    public void LevelSelect(int level)
    {
        Application.LoadLevel(level);
        //Application.LoadLevel("Level1");
    
    }
    public void Options()
    {
        Application.LoadLevel("Options");
        //Application.LoadLevel("Level1");
    
    }

    public void Quit()
    {
        Application.Quit();
        //Application.LoadLevel("Level1");
    }
}