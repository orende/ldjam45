using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectebulClueSertcher : MonoBehaviour
{
    private GameObject[] children;
    public ConnectableClues[] clues;
    // Start is called before the first frame update
    void Start()
    {
        int childCount = this.gameObject.transform.childCount;
        children = new GameObject[childCount];
        clues = new ConnectableClues[childCount];
        for (int i = 0; i < childCount; i++)
        {
            // this.gameObject.transform.GetChild(i).gameObject.SetActive(false);
            children[i] = this.gameObject.transform.GetChild(i).gameObject;
            clues[i] = this.gameObject.transform.GetChild(i).gameObject.GetComponent<ConnectableClues>();
        }
    }

    public void goFrue(GameObject dataA,GameObject dataB)
    {
        foreach (var item in clues)
        {
            item.Evaluate(dataA, dataB);
        }
    }
}
