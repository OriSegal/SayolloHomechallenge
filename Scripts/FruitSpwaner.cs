using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpwaner : MonoBehaviour
{
    public GameObject Fruit;
    float RandomY;
    float TimeToSpwan;

    void Start()
    {
        SpwanFruit();
    }

    void SpwanFruit()//In charge to spwan Fruits and in random locations
    {
        TimeToSpwan = Random.Range(6f, 10f);
        RandomY = Random.Range(-4f, 4f);
        Instantiate(Fruit, new Vector2(12, RandomY), Quaternion.identity);
        Invoke("SpwanFruit", TimeToSpwan);
    }
}
