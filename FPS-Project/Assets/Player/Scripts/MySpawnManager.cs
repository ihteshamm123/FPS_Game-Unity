using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    private float spawnRangeX;
    private float spawnPosZ ;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    public float EnemyCount;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAnimal()
    {
        //while (EnemyCount > 11)
        //{
        spawnRangeX = Random.Range(110, 220);
        spawnPosZ = Random.Range(110, 130);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawmPos = new Vector3(spawnRangeX, 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawmPos
            , animalPrefabs[animalIndex].transform.rotation);
        //  }
    }
}