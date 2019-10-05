using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isDragging = false;
    void Start()
    {
             
    }

    // Update is called once per frame
    void OnGui()
    {
      if(Input.GetMouseButton(1)) {
        this.isDragging = true;
      } else {
        this.isDragging = false;
      }

      if(isDragging()) {

      }
    }
}
