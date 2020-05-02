using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Tosser : MonoBehaviour
{

    public static new int score = 0;
//    public GameObject camera;

    public Rigidbody pumpkin;
    public float initialSpeed = 1500f;
    private float moveSpeed = 5f;
    private static int pumpkinCount = 0;
    private static bool isGameOver = false;
    void Start()
    {
    }
    void Update()
    {

        

        float deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float deltaY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(deltaX, deltaY, 0);
        if (Input.GetButtonUp("Fire1"))
        {
            Rigidbody pumpkinInstance = Instantiate(pumpkin, transform.position, transform.rotation) as Rigidbody;
            pumpkinCount++;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
           // if (Physics.Raycast(ray, out hit))
            {
               // pumpkinInstance.transform.LookAt(hit.point);
               // pumpkinInstance.velocity = pumpkinInstance.transform.forward * initialSpeed;
            }
        }
    }
}
   