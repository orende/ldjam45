using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectLine : MonoBehaviour
{
    public Transform connecteeA;
    public Transform connecteeB;

    private LineRenderer lineA;
    
    // Start is called before the first frame update
    void Start()
    {
        lineA = gameObject.GetComponent<LineRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        lineA.SetPositions(new Vector3[]{connecteeA.position,connecteeB.position});
    }
}
