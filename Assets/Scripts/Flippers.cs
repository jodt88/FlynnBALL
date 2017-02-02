/* Original Script HingeFlicker.cs by Gregory Yoes-Favrot.
 * Edited for use in FlynnBALL by Jody Toms 
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flippers : MonoBehaviour
{
    HingeJoint2D hingeJoint1;
    JointMotor2D jointMotor;

    void Start()
    {
        hingeJoint1 = gameObject.GetComponent<HingeJoint2D>();
        jointMotor = hingeJoint1.motor;
        JointAngleLimits2D limits = hingeJoint1.limits;
        limits.min = -30;
        limits.max = 30;
        hingeJoint1.limits = limits;
        hingeJoint1.useLimits = true;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            jointMotor.motorSpeed = 2000;
            hingeJoint1.motor = jointMotor;
        }
        else
        {
            jointMotor.motorSpeed = -2000;
            hingeJoint1.motor = jointMotor;
        }
        hingeJoint1.motor = jointMotor;

    }
}
