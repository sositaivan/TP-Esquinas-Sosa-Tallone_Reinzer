using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductoScript : MonoBehaviour
{
    public GameObject[] productoAsset; 
    public Transform objectSpawnPoint; 
    public float interval;
    public BotonesUI randomSpawn;
    public int objectCounter = 0;
    public int maxSpawnedObjects;
    void Start()
    {
        InvokeRepeating(nameof(CloneFodd), 0, interval);
        maxSpawnedObjects = Random.Range(2, 8);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
