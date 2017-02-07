/* GameOver.cs -- A script for detecting that the hero pinball went through the hole. Displays the number of pinballs left, 
 * as well as the overall highscore. Resets the board while pinballs remain. Displays game over prompt when pinballs run out.
 * Also stores the highscore if a new one exists.
 * 
 * Written by Jody Toms.
 */

using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject endText;

    public TextMesh ballCountText;

    public TextMesh highScoreText;

    void Start()
    {
        ballCountText = GameObject.Find("Ball Counter").GetComponent<TextMesh>();
        ballCountText.GetComponent<TextMesh>().text = "Ball Count: " + TotalScore.ballCount;

        highScoreText = GameObject.Find("High Score").GetComponent<TextMesh>();
        highScoreText.GetComponent<TextMesh>().text = "High Score: " + PlayerPrefs.GetInt("HighScore");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "ball")
        {
            if (TotalScore.ballCount > 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                TotalScore.ballCount -= 1;
            }
            else
            {
                endText.transform.localScale = new Vector3(1, 1, 1);
                DestroyObject(GameObject.Find("rezzBall"));
                DestroyObject(other.gameObject);
                if (PlayerPrefs.GetInt("HighScore") < TotalScore.score)
                {
                    PlayerPrefs.SetInt("HighScore", TotalScore.score);
                }
            }
        }
    }
 }
