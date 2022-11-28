using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class OptionsMenu : MonoBehaviour
{

    public Slider volumeSlider;
    public Slider sensitivitySlider;
    public Toggle invertYToggle;
    public Toggle fullscreenToggle;
    // options menu
    public void Options()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void Apply()
    {
        // apply volume
        AudioListener.volume = volumeSlider.value;
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
