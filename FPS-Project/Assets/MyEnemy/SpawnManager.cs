using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 900;
    private float spawnPosZ = 900;
    private float startDelay = 2;
    private float spawnInterval = 9f;
    public float EnemyCount;
    
    [SerializeField]
    private int Cube_Enemy_Count;

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
        int index = 0;

        for (int i = 0; i < Cube_Enemy_Count; i++)
        {
            spawnRangeX = Random.Range(100, 800);
        spawnPosZ = Random.Range(100, 850);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawmPos = new Vector3(spawnRangeX, 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawmPos
            , animalPrefabs[animalIndex].transform.rotation);
          }
    }
}


/*public static SpawnManager instance;

[SerializeField]
private GameObject Cube_Prefab;

public Transform[] Cube_SpawnPoints;

[SerializeField]
private int Cube_Enemy_Count;

private int initial_Cube_Count;

public float wait_Before_Spawn_Enemies_Time = 10f;

// Use this for initialization
void Awake()
{
    MakeInstance();
}

void Start()
{
    initial_Cube_Count = Cube_Enemy_Count;

    SpawnEnemies();

    StartCoroutine("CheckToSpawnEnemies");
}

void MakeInstance()
{
    if (instance == null)
    {
        instance = this;
    }
}

void SpawnEnemies()
{
    SpawnCube();
}

void SpawnCube()
{

    int index = 0;

    for (int i = 0; i < Cube_Enemy_Count; i++)
    {

        // if (index >= Cube_SpawnPoints.Length) {
        index = 0;
        //}

        Instantiate(Cube_Prefab, Cube_SpawnPoints[index].position, Quaternion.identity);

        //index++;

    }

    Cube_Enemy_Count = 0;

}



IEnumerator CheckToSpawnEnemies()
{
    yield return new WaitForSeconds(wait_Before_Spawn_Enemies_Time);

    SpawnCube();
    StartCoroutine("CheckToSpawnEnemies");

}

public void EnemyDied(bool Cube)
{



    Cube_Enemy_Count++;

    if (Cube_Enemy_Count > initial_Cube_Count)
    {
        Cube_Enemy_Count = initial_Cube_Count;


    }

}
public void StopSpawning()
{
    StopCoroutine("CheckToSpawnEnemies");
}

} 













































/*public GameObject[] animalPrefabs;
private float spawnRangeX = 0;
private float spawnPosZ = 0;
private float startDelay = 2;
private float spawnInterval = 1.5f;

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
    //        if (Input.GetKeyDown(KeyCode.S))
    //        {
    int animalIndex = Random.Range(0, animalPrefabs.Length);
    Vector3 spawmPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
        0, spawnPosZ);
    Instantiate(animalPrefabs[animalIndex], spawmPos
        , animalPrefabs[animalIndex].transform.rotation);
    //        }
}
}
*/
