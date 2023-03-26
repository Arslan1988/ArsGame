using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    private Rigidbody _rigidBody;
    public float speed = 5f, rotateSpeed = 1f;
    

    private void Awake()
    {
        _rigidBody= GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
       float sideForse = Input.GetAxis("Horizontal")*rotateSpeed;
       float forwardForse = Input.GetAxis("Vertical")*speed;
       _rigidBody.AddRelativeForce(0f,0f,forwardForse);
       _rigidBody.AddRelativeTorque(0f,sideForse,0f);

    }
}
