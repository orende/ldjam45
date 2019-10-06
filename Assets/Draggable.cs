using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Draggable : EventTrigger {
    private bool isDragging = false;

    [SerializeField]
    public Rigidbody2D rig;

    private ModeHandlerScript modeHandler;
    private ConectClues clueHandler;

    void Start() {
        rig = GetComponent<Rigidbody2D>();
        Debug.Log("rig:"+ rig);
        modeHandler = GameObject.FindObjectOfType<ModeHandlerScript>();
        clueHandler = GameObject.FindObjectOfType<ConectClues>();
    }

    void Update() {
     
    }

    public override void OnBeginDrag(PointerEventData data)
    {
        if (modeHandler.mode == ModeHandlerScript.MouseMode.MOVE) { 
            isDragging = true;
        }
    }

    public override void OnCancel(BaseEventData data)
    {
    }

    public override void OnDeselect(BaseEventData data)
    {
    }

    public override void OnDrag(PointerEventData data)
    {
        if (modeHandler.mode == ModeHandlerScript.MouseMode.MOVE) { 
            rig.transform.position += new Vector3(data.delta.x, data.delta.y, 0);
            // rig.transform.position += new Vector3(Input.mousePosition.x,Input.mousePosition.y, 0);
            Debug.Log("Position:" + rig.transform.position);
        }
    }

    public override void OnDrop(PointerEventData data)
    {
    }

    public override void OnEndDrag(PointerEventData data)
    {
        if (modeHandler.mode == ModeHandlerScript.MouseMode.MOVE) { 
            isDragging = false;
        }
    }

    public override void OnInitializePotentialDrag(PointerEventData data)
    {
    }

    public override void OnMove(AxisEventData data)
    {
    }

    public override void OnPointerClick(PointerEventData data)
    {
        if (modeHandler.mode == ModeHandlerScript.MouseMode.LOOKING_GLASS) {
            // DO ZOOM HERE
            Debug.Log("ZOOMING ON OBJECT");
            data.pointerPress.GetComponent<ZoomHandler>().Trigger();
        }

        if (modeHandler.mode == ModeHandlerScript.MouseMode.CONNECT_CLUES)
        {
            clueHandler.Conect(data.pointerPress);
        }
    }

    public override void OnPointerDown(PointerEventData data)
    {
    }

    public override void OnPointerEnter(PointerEventData data)
    {
    }

    public override void OnPointerExit(PointerEventData data)
    {
    }

    public override void OnPointerUp(PointerEventData data)
    {
    }

    public override void OnScroll(PointerEventData data)
    {
    }

    public override void OnSelect(BaseEventData data)
    {
    }

    public override void OnSubmit(BaseEventData data)
    {
    }

    public override void OnUpdateSelected(BaseEventData data)
    {
    }
}
