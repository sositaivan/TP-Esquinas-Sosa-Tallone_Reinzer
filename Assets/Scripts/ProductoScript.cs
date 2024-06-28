using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProductoScript : MonoBehaviour
{
    public GameObject[] productoAsset; 
    public Transform objectSpawnPoint; 
    public float interval;
    public SpawnerPosition randomSpawn;
    public int objectCounter = 0;
    public int maxSpawnedObjects;
    public InputField CantidadIngresada;
    public Text Txt_correcto;
    public Text Txt_incorrect;
    public GameObject Panel;
    
    void Start()
    {
        InvokeRepeating(nameof(ProductSpawner), 0, interval);
        maxSpawnedObjects = Random.Range(5, 15);
        Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ProductSpawner()
    {
        if(objectCounter < maxSpawnedObjects)
        {
            objectCounter++;
            randomSpawn.SetRandomPosition();
            GameObject prefab = productoAsset[Random.Range(0, productoAsset.Length)];
            Instantiate(prefab, objectSpawnPoint.position, objectSpawnPoint.rotation);
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void BotonResponder()
    {
        Panel.SetActive(true);
        int NumeroIngresado = int.Parse(CantidadIngresada.text);

        if(NumeroIngresado == objectCounter)
        {
            Txt_correcto.gameObject.SetActive(true);
        }
        else
        {
            Txt_incorrect.gameObject.SetActive(true);
        }

    }
    public void CerrarPanel()
    {
        Panel.SetActive(false);
    }
}
