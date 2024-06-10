using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private Rigidbody playerRB;
    public Vector3 _centerOfMass;
    public WheelColliders colliders;
    public WheelMeshes wheelMeshes;
    public float gasInput;
    public float steeringInput;

    public float motorPower;
    public float brakePower;
    private float speed;
    public AnimationCurve steeringCurve;

    void Start()
    {
        playerRB = gameObject.GetComponent<Rigidbody>();
        playerRB.centerOfMass = _centerOfMass;
    }

    void Update()
    {
        speed = playerRB.velocity.magnitude;
        CheckInput();
        if (Input.GetKey(KeyCode.Space))
        {
            ApplyBrakes();
        }
        else
        {
            ReBrake();
            ApplyMotor();
            ApplySteering();
        }
        ApplyWheelPositions();
    }

    void CheckInput()
    {
        gasInput = Input.GetAxis("Vertical");
        steeringInput = Input.GetAxis("Horizontal");
        

    }

    void ApplyMotor()
    {
        colliders.RRWheel.motorTorque = motorPower * gasInput;
        colliders.RLWheel.motorTorque = motorPower * gasInput;
    }

    void ApplySteering()
    {
        float steeringAngle = steeringInput * steeringCurve.Evaluate(speed);
        colliders.FRWheel.steerAngle = steeringAngle;
        colliders.FLWheel.steerAngle = steeringAngle;
    }
    void ApplyBrakes()
    {
        colliders.FRWheel.brakeTorque = brakePower;
        colliders.FLWheel.brakeTorque = brakePower;
        colliders.RRWheel.brakeTorque = brakePower;
        colliders.RLWheel.brakeTorque = brakePower;

        colliders.RRWheel.motorTorque = 0;
        colliders.RLWheel.motorTorque = 0;
    }
    void ReBrake()
    {
        colliders.FRWheel.brakeTorque = 0;
        colliders.FLWheel.brakeTorque = 0;
        colliders.RRWheel.brakeTorque = 0;
        colliders.RLWheel.brakeTorque = 0;
    }

    void ApplyWheelPositions()
    {
        UpdateWheel(colliders.FRWheel, wheelMeshes.FRWheel);
        UpdateWheel(colliders.FLWheel, wheelMeshes.FLWheel);
        UpdateWheel(colliders.RRWheel, wheelMeshes.RRWheel);
        UpdateWheel(colliders.RLWheel, wheelMeshes.RLWheel);


    }

    void UpdateWheel(WheelCollider coll, MeshRenderer wheelMesh)
    {
        Quaternion quat;
        Vector3 position;
        coll.GetWorldPose(out position, out quat);
        wheelMesh.transform.position = position;
        wheelMesh.transform.rotation = quat;
    }
}

[System.Serializable]
public class WheelColliders
{
    public WheelCollider FRWheel;
    public WheelCollider FLWheel;
    public WheelCollider RRWheel;
    public WheelCollider RLWheel;
}

[System.Serializable]
public class WheelMeshes  
{
    public MeshRenderer FRWheel;
    public MeshRenderer FLWheel;
    public MeshRenderer RRWheel;
    public MeshRenderer RLWheel;
}
