using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    private Rigidbody _rb;
    public float jump=10f, speed =1f;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        transform.Translate(Vector3.up*jump*Time.deltaTime);
    }
}
