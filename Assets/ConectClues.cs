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
    public void Conect(GameObject clue)
    {
        Debug.Log("Conect");
        if(clue != null)
        {
            if (firstClue==null)
            {
                firstClue=clue.transform;  
                Debug.Log("set furst:"+ clue);         
                return;
            }

            if(secundClue==null && clue.name != firstClue.name)
            {
                secundClue=clue.transform;
                Debug.Log("set secundClue:"+ clue.name);
            }

            if(firstClue != null && secundClue !=null)
            {
                Debug.Log("conect furst and secund");
                //conect furst and secund
                //EmtyConections();
            }
        }
        else
        {
            Debug.Log("Conect: No GameObject found");
        }
    }

    private void EmtyConections()
    {
        firstClue= null;
        secundClue =null;
    }
    //         if (modeHandler.mode == ModeHandlerScript.MouseMode.MOVE) { 
    //         isDragging = true;
    //     }
}
