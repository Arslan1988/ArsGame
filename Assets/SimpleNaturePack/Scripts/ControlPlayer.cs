using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ControlPlayer : MonoBehaviour
{
	/*Желательно делать контроллеры такими, чтобы они не знали ничего
	об объекте, которым управляют.
	Например дистанционка имеет только кнопки - отталкивайся от этого.
	*/
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
