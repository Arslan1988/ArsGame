using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Зачем этот класс? Если ты используешь в машине WheelCollider - этого достаточно
public class Wheel : MonoBehaviour
{
	/*На будущее, RigidBody должно быть у одного объекта родителя, 
	все что под ним будет двигаться как физ объект, просто нужны Collider там,
	где есть соприкосновения.

	Если бы мы писали свой класс WheelCollider, то он бы имел компонент Collider
	*/
    private Rigidbody _rigidBody;
    public float speed = 5f, rotateSpeed = 1f;
    

    private void Awake()
    {
        _rigidBody= GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
		//Вообще идея неплохая
       float sideForse = Input.GetAxis("Horizontal")*rotateSpeed;
       float forwardForse = Input.GetAxis("Vertical")*speed;
       _rigidBody.AddRelativeForce(0f,0f,forwardForse);
       _rigidBody.AddRelativeTorque(0f,sideForse,0f);

    }
}
