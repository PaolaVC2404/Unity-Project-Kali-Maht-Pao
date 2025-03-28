using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject EnemyTwoPrefab;
    public GameObject EnemyThreePrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateEnemyThree", 1, 2);
        InvokeRepeating("CreateEnemyTwo", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateEnemyThree()
    {
        Instantiate(EnemyThreePrefab, new Vector3(UnityEngine.Random.Range(-6f, 6f), 6.5f, 0), Quaternion.identity);
    }
    void CreateEnemyTwo()
    {
        Instantiate(EnemyTwoPrefab, new Vector3(UnityEngine.Random.Range(-9f, 9f), 6.5f, 0), Quaternion.identity);
    }
}
