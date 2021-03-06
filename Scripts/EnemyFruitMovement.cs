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
        DestroyObjectWhenOutOfView();
    }

    void Movement()//moveing fruits and enemys to the left 
    {
        rigidbody2D.velocity = new Vector2(Speed, 0);
    }

    void DestroyObjectWhenOutOfView()
    {
        if (transform.position.x < -16)
        {
            Destroy(gameObject);
        }
    }
}
