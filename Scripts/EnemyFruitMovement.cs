using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFruitMovement : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    public float Speed;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        rigidbody2D.velocity = new Vector2(Speed, 0);
    }
}
