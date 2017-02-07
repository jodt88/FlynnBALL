/* PauseGame.cs -- A script for pausing the game.
 * 
 * Written by Jody Toms.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1;
    }

    void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
            else if(Time.timeScale != 1)
            {
                Time.timeScale = 1;
            }
        }
    }
}
