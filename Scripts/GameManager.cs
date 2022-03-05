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

    public void RasieScore(int ScoreToRaise)
    {
        Score += ScoreToRaise;
    }

    public void GameOver()
    {
        GameManagerCanvas.SetActive(true);
        SetHighScore();
        Time.timeScale = 0;
    }

    void GetHighScore()
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

    void SetHighScore()
    {
        if(Score > HighScore)
        {
            PlayerPrefs.SetInt("HighScore", HighScore = Score);
        }
    }
}
