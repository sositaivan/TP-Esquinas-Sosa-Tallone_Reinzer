using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPosition : MonoBehaviour
{
    public int offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetRandomPosition()
    {
        Vector3 newPosition = new Vector3(Random.Range(0, offset), 9, Random.Range(0, offset));
        trasform.position = newPosition;
    }
}
