using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class WinTrigger : MonoBehaviour
{

    // Start is called before the first frame update
 
    
    public GameObject winText;
    public GameObject TimerText;
    public GameObject player;

    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (other.gameObject.name == "Player")
            {
                winText.SetActive(true);
                TimerText.SetActive(false);
                player.SetActive(false);
            }
        }

        void YouWin()
    {
        SceneManager.LoadScene("Level02");
    }

    void OnTriggerWin(Collider other)
    {
        Debug.Log("You Win");
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Win Canvas?!?");
            if (other.gameObject.name == "Player")
            {
                winText.SetActive(true);
                TimerText.SetActive(false);
                player.SetActive(false);
            }
            
        }
    }

    }
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
