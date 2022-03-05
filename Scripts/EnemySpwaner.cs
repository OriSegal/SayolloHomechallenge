using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpwaner : MonoBehaviour
{
    public GameObject Enemy;
    float RandomY;
    float TimeToSpwan;

    void Start()
    {
        SpwanEnemy();
    }

    void SpwanEnemy()//In charge to spwan enemys and in random locations
    {
        TimeToSpwan = Random.Range(3f, 7f);
        RandomY = Random.Range(-4f, 4f);
        Instantiate(Enemy, new Vector2(12, RandomY), Quaternion.identity);
        Invoke("SpwanEnemy", TimeToSpwan);
    }
}
