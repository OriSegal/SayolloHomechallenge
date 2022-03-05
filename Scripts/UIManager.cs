using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    GameManager gameManager;
    SoundsManager soundsManager;

    public Text Score;
    public Text HighScore;

    void Start()
    {
        gameManager = GetComponent<GameManager>();
        soundsManager = FindObjectOfType<SoundsManager>();
    }


    void Update()//update score to texts in the end game panle 
    {
        Score.text = "Score: " + gameManager.Score.ToString();
        HighScore.text = "HighScore: " + gameManager.HighScore.ToString();
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1;       
        soundsManager.ClickSound();
        SceneManager.LoadScene("MainMenu");
    }

    public void StartReStartGame()
    {
        Time.timeScale = 1;
        soundsManager.ClickSound();
        SceneManager.LoadScene("PlayScene");               
    }
}
