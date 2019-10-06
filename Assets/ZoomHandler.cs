using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ZoomHandler : MonoBehaviour
{    
    public UnityEvent zoomEvent;
   // private ModeHandlerScript modeHandler;

    // Start is called before the first frame update
    void Start()
    {
        //modeHandler = GameObject.FindObjectOfType<ModeHandlerScript>();
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        
    }

    public void Trigger(){ 
        zoomEvent.Invoke(); 
    }
}
