using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    //public float spawnInterval = 2f; // Time in seconds between each spawn.
    //private float timer = 0f;

    void Start(){
        SpawnObject();
    }

    void Update()
    {
        /*timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnObject();
            timer = 0f;
        }*/
    }

    //For only the middle platform
    void SpawnObject()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-8f, 8f), Random.Range(3, 0));
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }

    //For the whole platform
    /*void SpawnObject()
    {
        Vector2 spawnPosition = new Vector2(0, 0);
        switch(Random.Range(1, 7)){
            case 1:
                spawnPosition = new Vector2(Random.Range(-8f, 8f), transform.position.y);
                break;
            case 2:
                spawnPosition = new Vector2(Random.Range(-5f, 5f), 6);
                break;
            case 3:
                spawnPosition = new Vector2(Random.Range(10f, 17f), 2);
                break;
            case 4:
                spawnPosition = new Vector2(Random.Range(10f, 17f), -4);
                break;
            case 5:
                spawnPosition = new Vector2(Random.Range(-18f, -10f), 2);
                break;
            case 6:
                spawnPosition = new Vector2(Random.Range(-18f, -10f), -4);
                break;
            default:
                break;
        }
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }*/
}
