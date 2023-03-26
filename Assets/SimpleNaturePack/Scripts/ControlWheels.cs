using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Лишний класс, Контрол лучше весить на объект, которым управляет игрок
//Так тебе придется на каждое колесо весить этот скрипт
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
