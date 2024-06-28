using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductoScript : MonoBehaviour
{
    public GameObject[] productoAsset; 
    public Transform objectSpawnPoint; 
    public float interval;
    public SpawnerPosition randomSpawn;
    public int objectCounter = 0;
    public int maxSpawnedObjects;
    void Start()
    {
        InvokeRepeating(nameof(FoodSpawner), 0, interval);
        maxSpawnedObjects = Random.Range(5, 12);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FoodSpawner()
    {
        if(objectCounter < maxSpawnedObjects)
        {
            objectCounter++;
            randomSpawn.SetRandomPosition();
            GameObject prefab = productoAsset[Random.Range(0, productoAsset.Length)];
            Instantiate(prefab, objectSpawnPoint.position, objectSpawnPoint.rotation);
        }
    }
    public void DeactivateAll()
    {;
        for (int i = 0; i < productoAsset.Length; i++)
        {
            productoAsset[i].SetActive(false);
        }
    }
}
