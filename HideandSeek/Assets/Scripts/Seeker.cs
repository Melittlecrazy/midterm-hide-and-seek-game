using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Seeker : MonoBehaviour
{

    public float rotationSpeed;
    public GameObject loseText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 1);
        //if (true)
        //{

        // transform.Rotate(Vector3.up * rotationSpeed);

        //}
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            loseText.SetActive(true);
            GameOver.IsGameOver = true;
        }

    }
}
