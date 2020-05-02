using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
public class Alert : MonoBehaviour {
 
    public bool inTrigger;
 
    void OnTriggerEnter(Collider collider)
    {
        inTrigger = true;
        Debug.Log("Trigger");
    }
 
    void OnTriggerExit(Collider collider)
    {
        inTrigger = false;
    }
 
    void Update()
    {
        
    }
 
    void OnGUI()
    {
        if (inTrigger)
        {
            GUI.Box(new Rect(0, 60, 200, 25), "Key Nearby");
        }
    }
}
