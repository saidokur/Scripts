using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_Spawner : MonoBehaviour // Engellerle �ak��ma oluyor.
{
    public GameObject[] collectibles;
    public GameObject boss;
    

    public float collectibleHeight;
    public float collectibleDensity;

    void Start()
    {
        InvokeRepeating("Spawner", 1f,collectibleDensity);
    }

    void Spawner()
    {

        if (boss.transform.position.x == -2 || boss.transform.position.x == 0 || boss.transform.position.x == 2)
        {
            //liste i�inden eleman se�nmeyi buldum. Biraz da kaybolmas�n diye burada kulland�m.
            int[] spawnPoints = {-2, 0, 2};
            int randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            int randomSpawn = spawnPoints[randomSpawnPoint];  
            Instantiate(collectibles[Random.Range(0, collectibles.Length)], new Vector3(randomSpawn, boss.transform.position.y + collectibleHeight, boss.transform.position.z + 11.5f), Quaternion.identity);
        }
      
    }


}