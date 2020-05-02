using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
public class KeyScript : MonoBehaviour {
 
    public bool inTrigger;
 
    void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }
 
    void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }
 
    void Update()
    {
        if (inTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                DoorScript.doorKey = true;
                GameManager.keys+=1;
                FindObjectOfType<AudioManager>().Play("KeySound");
                Destroy(this.gameObject);
            }
        }
    }
 
    void OnGUI()
    {
        if (inTrigger)
        {
            GUI.Box(new Rect(0, 60, 200, 25), "Press E to take key");
        }
    }
}
