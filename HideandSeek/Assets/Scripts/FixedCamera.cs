using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedCamera : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        offset = transform.position - player.transform.position;
        transform.position = player.transform.position + offset;
    }
}
