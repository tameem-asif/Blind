using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerInteracions : MonoBehaviour
{
    public static float numKeys;
    [SerializeField] private Text keysText;
    [SerializeField] Transform playerPos;
    [SerializeField] Transform monsterPos;
    float pz;
    float mz;
    float mx;
    float px;
    float afterJump = 1;
    float counting;
    bool jumped = false;
    void Start()
    {
        numKeys = 0;
    }

    void Update()
    {
        numKeys = GameManager.keys;
        mz = monsterPos.position.z;
        pz = playerPos.position.z;
        mx = monsterPos.position.x;
        px = playerPos.position.x;
        if(DoorScript.open == true)
        {
            SceneManager.LoadScene("WinScreen");
        }

        if(mz == pz && mx == px && DoorScript.open == false)
        {
            SceneManager.LoadScene("LoseScreen");
        }

        if(countDownTimer.timer <= 0.0f && countDownTimer.doOnce == false)
        {
            SceneManager.LoadScene("LoseScreen");
        }

        keysText.text = "Keys: "+numKeys.ToString("F");

        if(Input.GetKeyDown("space"))
        {
            FindObjectOfType<AudioManager>().Play("Jump");
            jumped = true;
            counting = afterJump;
            counting-=Time.deltaTime;
            if(counting<=0)
            {
                FindObjectOfType<AudioManager>().Play("Land");
                counting = 0f;
            }
        }

        /*if(jumped==true)
        {
            counting = afterJump;
            counting -= Time.deltaTime;
            if(counting<=0f)
            {
                FindObjectOfType<AudioManager>().Play("Land");
                jumped = false;
                counting = 0f;
            }
        }*/

    }
}
