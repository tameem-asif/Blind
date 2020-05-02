using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonScript : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true;
        Screen.lockCursor = false;
    }
    public void InstructionsBtn()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void toLvlUno()
    {
        SceneManager.LoadScene("Blind");
    }
}
