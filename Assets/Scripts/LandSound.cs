using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandSound : MonoBehaviour
{
    void OnCollisionEnter(Collision info)
    {
        if(info.gameObject.name == "Floor")
        {
            FindObjectOfType<AudioManager>().Play("Land");
        }
    }
}
