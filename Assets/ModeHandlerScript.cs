using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeHandlerScript : MonoBehaviour
{
    public enum MouseMode {
        MOVE,
        LOOKING_GLASS,
        CONNECT_CLUES
    };

    public MouseMode mode = MouseMode.MOVE;

    void Start() {
        
    }

    void Update() {
        
    }

    public void setModeToMove() {
        mode = MouseMode.MOVE;
        Debug.Log("Setting mode to " + mode);
    }

    public void setModeToLookingGlass() {
        mode = MouseMode.LOOKING_GLASS;
        Debug.Log("Setting mode to " + mode);
    }

    public void setModeToConnectClues() {
        mode = MouseMode.CONNECT_CLUES;
        Debug.Log("Setting mode to " + mode);
    }
}
