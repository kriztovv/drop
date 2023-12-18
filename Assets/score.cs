using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public int Score;
    public Text ScoreText;
    public GameObject gameOverScreen;
    public bool ResultGameRunning;
    public deadzone myScript;
    public bool RunUpdate;

    void Start()
    {
        Score = 0;
        ResultGameRunning = true;
        RunUpdate = true;
    }


    void Update()
    {
        if(RunUpdate) {
            if (Input.GetMouseButtonDown(0))
            {
                Score = Score + 1;
                ScoreText.text = Score.ToString();
            }


            GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("object") ;
            foreach (GameObject obj in objectsWithTag)
            {
                deadzone script = obj.GetComponent<deadzone>();
                bool individualResult = script.gameRunning;
                if (!individualResult)
                {
                    ResultGameRunning = false;
                }
            }
                if (!ResultGameRunning)
            {
                gameOver();
                RunUpdate = false;
            }
        }

    }
    
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);

    }
}
