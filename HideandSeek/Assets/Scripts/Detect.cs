using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject body;
    public GameObject player;
    private Vector3 offset;
    

    void Update()
    {
        int layerMask = LayerMask.GetMask("Player");
        //layerMask = ~layerMask;
        RaycastHit hit;
        
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            if (hit.collider == (player.tag == "Player"))
            {
                offset = transform.position - player.transform.position;
                body.transform.Translate(Vector3.forward * Time.deltaTime * 1);
            }
        }
       
    }

}
