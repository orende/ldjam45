using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableChildren : MonoBehaviour
{
    private GameObject[] children;
    // Start is called before the first frame update
    void Start()
    {
        int childCount = this.gameObject.transform.childCount;
        children = new GameObject[childCount];
        for (int i = 0; i < childCount; i++) {
            // this.gameObject.transform.GetChild(i).gameObject.SetActive(false);
            children[i]= this.gameObject.transform.GetChild(i).gameObject;
        }  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisableChildrenObject(){
        foreach (var item in children)
        {
            item.SetActive(false);
        }
    }
}
