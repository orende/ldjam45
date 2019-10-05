using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AlternateDraggable : EventTrigger
{
    private bool dragging;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dragging) {
            transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
        }
    }

    public override void OnPointerDown(PointerEventData eventData) {
        if (eventData.button == PointerEventData.InputButton.Left) {
            Debug.Log ("Right Mouse Button Clicked on: " + name);
            dragging = true;
        }
        if (eventData.button == PointerEventData.InputButton.Right) {
            Debug.Log("RMB down");
        }
    }

    public override void OnPointerUp(PointerEventData eventData) {
        if (eventData.button == PointerEventData.InputButton.Left) {
            dragging = false;
        }
        if (eventData.button == PointerEventData.InputButton.Right) {
            Debug.Log("RMB up");
        }
    }
}
