using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Transform player;
    public Transform MyTarget;
    public float chase = 10.0f;
    public float smooth = 10.0f;
    private Vector3 smoothVel = Vector3.zero;
    
    

    void Update()
    {

        float distance = Vector3.Distance(transform.position, player.position);
        if (distance < 2.0f)
        {
            transform.LookAt(player);
            transform.position = Vector3.SmoothDamp(transform.position, player.position, ref smoothVel, smooth);
           
        }
    }

}
