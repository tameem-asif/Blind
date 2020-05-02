using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    [SerializeField] private Text scoreTxt;
    float score;

    void Start()
    {
        score = 180-countDownTimer.timer;
    }

    void Update()
    {
        scoreTxt.text = "Your Time: "+score.ToString("F");
    }
}
