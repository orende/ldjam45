using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameObject))]
public class Draggable : MonoBehaviour {
    public GameObject parentGameObject;

    private bool isDragging = false;
    void Start() {
             
    }

    void Update() {
      if (Input.GetMouseButton(1)) {
        this.isDragging = true;
        Debug.Log("Dragging");
      } else {
        this.isDragging = false;
      }

      if (isDragging) {
        Debug.Log(Input.mousePosition);
        parentGameObject.transform.position = Input.mousePosition;
      }
    }
}
