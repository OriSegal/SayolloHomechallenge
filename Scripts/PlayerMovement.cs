using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    SoundsManager soundsManager;

    public GameObject FireEffect;
    bool isFlying;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        soundsManager = FindObjectOfType<SoundsManager>();
        isFlying = false;
    }

    void Update()
    {
        MouseButton();     
    }

    private void LateUpdate()
    {
        Fly();
    }

    void MouseButton()
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

    void Fly()
    {
        if (isFlying)
        {
            rigidbody2D.velocity = new Vector2(0, 4);
            FireEffect.SetActive(true);
        }
        else
        {
            FireEffect.SetActive(false);
        }
    }
}
