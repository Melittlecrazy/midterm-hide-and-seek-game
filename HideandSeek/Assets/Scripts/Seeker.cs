using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Seeker : MonoBehaviour
{
    Animator anim;
    public float stopAndLook = 10.0f;
    public GameObject loseText;
    public GameObject body;
    public float xRange = 10;

    public static bool IsGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    { 
            //anim.SetBool("move",true);
        transform.Translate(Vector3.forward *Time.deltaTime* stopAndLook);
        
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            loseText.SetActive(true);
            GameOver.IsGameOver = true;
        }
        if (other.tag == "tree")
        {
            body.transform.Rotate(0,180,0,0);
        }
    }
    
}
