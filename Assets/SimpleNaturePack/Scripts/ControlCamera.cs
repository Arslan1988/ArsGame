using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamera : MonoBehaviour
{
private float horizontal,vertical,doubleSpeed,scrollCamera;
public float cameraSpeed=20f;
private float rotateSpeed = 5f;



    void Update()
    {
        horizontal=Input.GetAxis("Horizontal");
        vertical= Input.GetAxis("Vertical");
        doubleSpeed= Input.GetKey(KeyCode.LeftShift)?2:1;
        if (Input.GetKey(KeyCode.A))
        transform.Rotate(Vector3.up*-1*Time.deltaTime*cameraSpeed*rotateSpeed*doubleSpeed);
        if (Input.GetKey(KeyCode.D))
        transform.Rotate(Vector3.up*1*Time.deltaTime*cameraSpeed*rotateSpeed*doubleSpeed);
        transform.Translate(new Vector3(0,0,vertical)*Time.deltaTime*cameraSpeed*doubleSpeed);
        transform.position+=transform.up *500f*Time.deltaTime*Input.GetAxis("Mouse ScrollWheel");
        transform.position=new Vector3(transform.position.x, Mathf.Clamp(transform.position.y,-25,30),transform.position.z);
    }
}
