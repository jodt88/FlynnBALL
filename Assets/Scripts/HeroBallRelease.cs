/* HeroBallRelease.cs -- A script for releasing the player's pinball.
 * 
 * Written by Jody Toms.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroBallRelease : MonoBehaviour
{
    HingeJoint2D[] hingeJoints;

    JointMotor2D jointMotor;

    void Start()
    {
        hingeJoints = gameObject.GetComponents<HingeJoint2D>();
        jointMotor = hingeJoints[0].motor;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            jointMotor.motorSpeed = -3000;
        }
        else
        {
            jointMotor.motorSpeed = 0;
        }
        hingeJoints[0].motor = jointMotor;
    }
}
