using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConectClues : MonoBehaviour
{

    public Transform firstClue;
    public Transform secundClue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Conect(GameObject clue)
    {
        if (firstClue==null)
        {
            firstClue=clue.transform;
            return;
        }

        if(secundClue==null)
        {
            secundClue=clue.transform;
        }

        if(firstClue != null && secundClue !=null)
        {
            //conect furst and secund
            firstClue= null;
            secundClue =null;
        }
    }

    //         if (modeHandler.mode == ModeHandlerScript.MouseMode.MOVE) { 
    //         isDragging = true;
    //     }
}
