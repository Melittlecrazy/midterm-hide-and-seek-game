using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerControl : MonoBehaviour
{
    private int walkingSpeed= 9;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        { 
            transform.Translate(Vector3.right * Time.deltaTime * walkingSpeed); 
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * walkingSpeed);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * walkingSpeed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * Time.deltaTime * walkingSpeed);
        }
    }
}
