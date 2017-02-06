using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour {
	
	void Update () {
        if (Input.GetKey(KeyCode.J))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            TotalScore.score = 0;
            TotalScore.ballCount = 3;
        }
	}
}
