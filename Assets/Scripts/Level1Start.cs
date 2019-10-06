using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Start : MonoBehaviour
{
    public GameObject blubb;


    void Start()
    {
        blubb.GetComponent<DialogPlayer>().triggerDialog("Level1Intro");
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
