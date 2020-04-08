using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public GameObject[] treesPrefab;
    private float spawnRangeX = 20;
    private float spawnPosZ = -10;
   
    void Start()
    {
        for (int i = 0; i <= 420; i++ )
        {
        int treeIndex = Random.Range(0, treesPrefab.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(15, spawnPosZ));
        Instantiate(treesPrefab[treeIndex], spawnPos, treesPrefab[treeIndex].transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
            
        
    }
}
