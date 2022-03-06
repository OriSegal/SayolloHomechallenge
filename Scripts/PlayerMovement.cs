using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    SoundsManager soundsManager;

    public GameObject FireEffect;
    [HideInInspector]
    public bool isFlying;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        soundsManager = FindObjectOfType<SoundsManager>();
        isFlying = false;
    }

    void Update()//check every frame mouse pressed
    {
        MouseButton();     
    }

    void LateUpdate()//move the object after checking mouse pressed give better result
    {
        Fly();
    }

    void MouseButton()//In charge of the mouse press
    {
        if (Input.GetMouseButtonDown(0))
        {
            isFlying = true;
            soundsManager.PlayJetSound();
        }

        if (Input.GetMouseButtonUp(0))
        {
            isFlying = false;
            soundsManager.StopJetSound();
        }
    }

    void Fly()//In charge of the movement
    {
        if (isFlying)
        {
            rigidbody2D.velocity = new Vector2(0, 5);
            FireEffect.SetActive(true);
        }
        else
        {
            FireEffect.SetActive(false);
        }
    }
}
