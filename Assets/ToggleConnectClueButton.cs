using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleConnectClueButton : MonoBehaviour
{
    private ModeHandlerScript modeHandler;

    // Start is called before the first frame update
    void Start()
    {
        modeHandler = GameObject.FindObjectOfType<ModeHandlerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick() {
        modeHandler.setModeToConnectClues();
    }
}
