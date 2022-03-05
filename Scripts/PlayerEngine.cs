using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEngine : MonoBehaviour
{
    GameManager gameManager;
    SoundsManager soundsManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        soundsManager = FindObjectOfType<SoundsManager>();
    }


    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Fruit")
        {
            soundsManager.FruitSound();
            gameManager.RasieScore(1);
            Destroy(collision.gameObject);
        }
        else if(collision.gameObject.tag == "Enemy")
        {
            soundsManager.HitSound();
            gameManager.GameOver();
        }
    }
}
