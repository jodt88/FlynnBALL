using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rezzBallRelease : MonoBehaviour
{
    public HingeJoint2D[] hingeJoints;
    public JointMotor2D jointMotor;

    void Start()
    {
        hingeJoints = GameObject.Find("new flipper left (1)").GetComponents<HingeJoint2D>();
        jointMotor = hingeJoints[0].motor;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "ball")
        {
            jointMotor.motorSpeed = 3000;
            hingeJoints[0].motor = jointMotor;
        }
    }
}
