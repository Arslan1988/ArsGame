using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlWheels : MonoBehaviour
{
    private float wheelsSpeed =10f;

    void Update()
    {  
        if (Input.GetKey(KeyCode.W))
        transform.Rotate(new Vector3(wheelsSpeed,0,0));
         if (Input.GetKey(KeyCode.S))
        transform.Rotate(new Vector3(-wheelsSpeed,0,0));            
    }
}
