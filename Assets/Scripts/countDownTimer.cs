using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countDownTimer : MonoBehaviour
{
    [SerializeField] private Text uiText;
    [SerializeField] private float mainTimer;
    public static float timer;
    private bool canCount = true;
    public static bool doOnce = false;
    void Start()
    {
        timer=mainTimer;
        canCount = true;
        doOnce = false;
    }

    void Update()
    {
        if(timer >= 0.0f && canCount)
        {
            timer -= Time.deltaTime;
            uiText.text = "Time Left: "+timer.ToString("F");
        }

        else if(timer <= 0.0f && !doOnce)
        {
            canCount = false;
            doOnce = true;
            uiText.text = "Time Left: 0.00";
            timer = 0.0f;
        }
    }
}
