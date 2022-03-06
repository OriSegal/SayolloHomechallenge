using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEngine : MonoBehaviour
{
    Animator animator;
    GameManager gameManager;
    SoundsManager soundsManager;
    PlayerMovement playerMovement;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        soundsManager = FindObjectOfType<SoundsManager>();
        animator = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }


    void Update()
    {
        SetAnime();
    }

    void OnTriggerEnter2D(Collider2D collision)//In charge of behavior when collide with different objects
    {
        if (collision.gameObject.tag == "Fruit")
        {
            soundsManager.FruitSound();
            gameManager.RasieScore(1);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Enemy")
        {
            soundsManager.HitSound();
            gameManager.GameOver();
            collision.GetComponent<Animator>().Play("Enemy_Dead");
            animator.Play("Cat_Dead");
        }
        else if (collision.gameObject.tag == "Border")
        {
            soundsManager.HitSound();
            gameManager.GameOver();
        }
    }

    void SetAnime()
    {
        if (playerMovement.isFlying)
        {
            animator.SetBool("isFly", true);
        }
        else
        {
            animator.SetBool("isFly", false);
        }
    }
}
