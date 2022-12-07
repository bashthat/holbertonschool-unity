using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class OptionsMenu : MonoBehaviour
{

     // options menu
    public void Options()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void Apply()
    {
        // apply volume
       
        
        // apply sensitivity
        
        // apply invertY

        // apply fullscreen
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

    
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {



    }
}

