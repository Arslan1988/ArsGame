using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWheel : MonoBehaviour
{
    private float wheelRotate= 5f;
    private float castorWheel;
    
    void Update()
    {
        castorWheel += Mathf.Clamp(transform.rotation.y,-40,40);
        if (Input.GetKey(KeyCode.D))
        transform.Rotate(new Vector3(0,castorWheel,0));
        if (Input.GetKey(KeyCode.A))
        transform.Rotate(new Vector3(0,-castorWheel,0));
    }
}
