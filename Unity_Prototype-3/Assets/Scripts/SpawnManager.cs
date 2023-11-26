using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPosition = new Vector3(25,0,0);
    private float startDelay =1;
    private float repeatRate =2;

    void Start()
    {
        InvokeRepeating("SpawnObstacle",startDelay,repeatRate);
    }

    
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
    }
}
