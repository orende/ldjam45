using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ConectClues : MonoBehaviour
{

    public GameObject firstClue;
    public GameObject secundClue;
    public ConnectebulClueSertcher sertcher;

    // Start is called before the first frame update
    void Start()
    {
        sertcher = GameObject.FindObjectOfType<ConnectebulClueSertcher>(); 
    }
    public void Conect(GameObject clue)
    {
        Debug.Log("Conect");
        if(clue != null)
        {
            if (firstClue==null)
            {
                firstClue=clue;  
                Debug.Log("set furst:"+ clue);         
                return;
            }

            if(secundClue==null && clue.name != firstClue.name)
            {
                secundClue=clue;
                Debug.Log("set secundClue:"+ clue.name);
            }

            if(firstClue != null && secundClue !=null) //conect furst and secund
            {
                Debug.Log("conect furst and secund");
                sertcher.goFrue(firstClue,secundClue);
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
}
