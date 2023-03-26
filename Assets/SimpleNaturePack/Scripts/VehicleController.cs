using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleController : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [Header("Controls")]
    public float accel, brake, backDraft, steering;
    [Header("Vehicle Steeings")]
    public float enginePower=250f, brakeForse=30000f,steerAngles =35f;

	//Можно объединить в один массив, но лучше использовать List<WheelCollider>
	//Но если есть смысл в разделении, то можно и разделить
	//Если ты делишь машину на передний привод и т д
    [Header("Wheels")] 
    public WheelCollider[] frontWheels;
    public WheelCollider[] rearWheels;
	
    public Vector3 centerMass;

    void Start()
    {
        _rigidbody.GetComponent<Rigidbody>();

		//зачем это?
        _rigidbody.centerOfMass = centerMass;
    }

    void Update()
    {
        accel = Input.GetAxis("Accel")*enginePower;
        brake = Input.GetAxis("Brake");
        backDraft = Input.GetAxis("Back Draft")*-enginePower;
        steering = Input.GetAxis("Horizontal");

        foreach(WheelCollider wheel in frontWheels)
        wheel.motorTorque= accel;
        foreach (WheelCollider wheel in rearWheels)
        wheel.motorTorque = accel;

        foreach(WheelCollider wheel in frontWheels)
        wheel.brakeTorque = brakeForse * brake; 
        foreach(WheelCollider wheel in rearWheels)
        wheel.brakeTorque = brakeForse * brake;

        foreach(WheelCollider wheel in frontWheels)
        wheel.motorTorque = backDraft;
        // foreach(WheelCollider wheel in rearWheels)
        // wheel.motorTorque = backDraft;

        foreach (WheelCollider wheel in frontWheels)
        wheel.steerAngle = steerAngles * steering;

		/* Лучше написать так:
		foreach(WheelCollider wheel in frontWheels) {
			wheel.motorTorque= accel;
			wheel.brakeTorque = brakeForse * brake;
			wheel.motorTorque = backDraft;
			wheel.steerAngle = steerAngles * steering;
		}
		foreach(WheelCollider wheel in rearWheels) {
			wheel.motorTorque = accel;
			wheel.brakeTorque = brakeForse * brake;
		}
		*/
    }
}
