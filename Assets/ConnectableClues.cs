using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ConnectableClues : MonoBehaviour
{
    public GameObject[] connectableClues;
    public GameObject objektA;
    public GameObject objektB;

    public UnityEvent ifConnected;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Evaluate(GameObject dataA, GameObject dataB)
    {
        if (dataA == objektA || dataA == objektB)
        {
            if(dataB==objektB||dataB==objektA)
            {
                ifConnected.Invoke();
            }
        }//connectableClues.
    }
}
