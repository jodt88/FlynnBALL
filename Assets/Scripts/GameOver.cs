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
                if (TotalScore.highScore < TotalScore.score)
                {
                    TotalScore.highScore = TotalScore.score;
                    PlayerPrefs.SetInt("HighScore", TotalScore.highScore);
                }
            }
        }
    }
 }
