using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject GameManagerCanvas;
    public int Score;
    public int HighScore;

    void Start()
    {
        GetHighScore();
    }


    void Update()
    {
        
    }

    public void RasieScore(int ScoreToRaise)//call this function when collide with fruit to raise score
    {
        Score += ScoreToRaise;
    }

    public void GameOver()
    {
        GameManagerCanvas.SetActive(true);
        SetHighScore();
        Time.timeScale = 0;
    }

    void GetHighScore()//check if there is data saved on the computer
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            HighScore = PlayerPrefs.GetInt("HighScore");
        }
        else
        {
            PlayerPrefs.SetInt("HighScore", HighScore);
        }
    }

    void SetHighScore()//save high score data on the computer
    {
        if(Score > HighScore)
        {
            PlayerPrefs.SetInt("HighScore", HighScore = Score);
        }
    }
}
