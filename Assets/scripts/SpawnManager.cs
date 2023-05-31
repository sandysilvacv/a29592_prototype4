using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefabs;
    private float spawnRange = 9;



    void Start()
    {
        float spawnPosX = Random.Range(spawnRange, spawnRange);
        float spawnPosz = Random.Range(spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosz);
        Instantiate(enemyPrefabs, randomPos, enemyPrefabs.transform.rotation);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
