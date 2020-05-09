using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public GameObject[] treesPrefab;
    public float spawnRangeX = 20;
    public float spawnDepth = -20;
    public float spawnHeight = .5f;
    public float spawnPosZ = -10;
    public float spawnRangeZ = 15;
    public float spawnAmount = 420;

   
    void Start()
    {
        for (int i = 0; i <= spawnAmount; i++ )
        {
        int treeIndex = Random.Range(0, treesPrefab.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnDepth, spawnRangeX), spawnHeight, Random.Range(spawnRangeZ, spawnPosZ));
        Instantiate(treesPrefab[treeIndex], spawnPos, treesPrefab[treeIndex].transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
            
        
    }
}
