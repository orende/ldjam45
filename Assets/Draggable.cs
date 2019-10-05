﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Draggable : EventTrigger {
    private bool isDragging = false;

    void Start() {
    }

    void Update() {
     
    }

    public override void OnBeginDrag(PointerEventData data)
    {
        isDragging = true;
    }

    public override void OnCancel(BaseEventData data)
    {
    }

    public override void OnDeselect(BaseEventData data)
    {
    }

    public override void OnDrag(PointerEventData data)
    {
        transform.position += new Vector3(data.delta.x, data.delta.y, 0);
    }

    public override void OnDrop(PointerEventData data)
    {
    }

    public override void OnEndDrag(PointerEventData data)
    {
        isDragging = false;
    }

    public override void OnInitializePotentialDrag(PointerEventData data)
    {
    }

    public override void OnMove(AxisEventData data)
    {
    }

    public override void OnPointerClick(PointerEventData data)
    {
        if (!isDragging)
        {
            Debug.Log("Click.");
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
