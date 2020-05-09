using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedCamera : MonoBehaviour
{
    
    public Vector3 offset;
    public Transform target;
    public float smooth = 0.125f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void fixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, desiredPosition, smooth);
        offset = transform.position - target.transform.position;
        transform.position = desiredPosition;
    }
}
