/* BallSlower.cs -- A script for decreasing the velocity of an object.
 * 
 * Written by Jody Toms.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSlower : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.GetComponent<Rigidbody2D>().velocity = other.gameObject.GetComponent<Rigidbody2D>().velocity / 2;
    } 
}
