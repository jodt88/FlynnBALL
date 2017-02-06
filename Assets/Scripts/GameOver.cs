using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject endText;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "ball")
        {
            endText.transform.localScale = new Vector3(1, 1, 1);
            DestroyObject(GameObject.Find("rezzBall"));
        }
        DestroyObject(other.gameObject);
    }
 }
