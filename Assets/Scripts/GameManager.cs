using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static float keys = 0;
    void Update()
    {
        Scene meh = SceneManager.GetActiveScene();

        if(meh.name == "StartScreen" || meh.name == "Instructions")
        {
            if(FindObjectOfType<AudioManager>().isPlaying("MainTheme") == false)
            {
                FindObjectOfType<AudioManager>().Play("MainTheme");
            }
        }
        else
        {
            FindObjectOfType<AudioManager>().pause("MainTheme");
        }

        if(meh.name == "Blind" && keys == 0)
        {
            if(FindObjectOfType<AudioManager>().isPlaying("CreepyMusic") == false)
            {
                FindObjectOfType<AudioManager>().Play("CreepyMusic");
            }
        }
        else if(meh.name == "Blind" && keys == 1)
        {
            FindObjectOfType<AudioManager>().pause("CreepyMusic");

            if(FindObjectOfType<AudioManager>().isPlaying("After_Key") == false)
            {
                FindObjectOfType<AudioManager>().Play("After_Key");
            }
        }
        else
        {
            FindObjectOfType<AudioManager>().pause("CreepyMusic");
            FindObjectOfType<AudioManager>().pause("After_Key");
        }

        if(meh.name == "WinScreen" || meh.name == "LoseScreen")
        {
            if(FindObjectOfType<AudioManager>().isPlaying("Background") == false)
            {
                FindObjectOfType<AudioManager>().Play("Background");
            }
        }

        else
        {
            FindObjectOfType<AudioManager>().pause("Background");
        }

        if(Input.GetKeyDown("escape"))
        {
            Debug.Log("Quitting");
            Application.Quit();
        }
    }
}
