﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playLaugh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Laugh");
    }
}
