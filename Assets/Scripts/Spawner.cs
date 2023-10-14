using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float spawnCD;
    private float spawnCDTimer;

    [SerializeField] private GameObject enemy;
    [SerializeField] private Transform[] spawnPoints;

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnCDTimer)
        { 
            spawnCDTimer = Time.time + spawnCD;
            Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(enemy, randomSpawnPoint.position, Quaternion.identity);
        }
    }
}
