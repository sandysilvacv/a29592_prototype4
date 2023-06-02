using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefabs;
    private float spawnRange = 9;



    void Start()
    {
        SpawnEnemyWave(3);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemyWave(int enemisToSpawn)
    {
        for (int i = 0; i < enemisToSpawn; i++)
        {
            Instantiate(enemyPrefabs, GenerateSpawnPosition(), enemyPrefabs.transform.rotation);
        }

    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosz = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosz);

        return randomPos;
    }
}
