using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefabs;
   
    void Start()
    {
        Instantiate(enemyPrefabs, new Vector3(0, 0, 6), enemyPrefabs.transform.rotation);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
