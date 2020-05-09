using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Animator))]
public class PLayerControl : MonoBehaviour
{
    private int walkingSpeed= 5;
    private Rigidbody player;
    public GameObject controls;
    public GameObject keyCam;
    public GameObject doorCam;
    public GameObject keyText;
    public GameObject doorText;
    public float jumpForce;
    public float gravityModifier;
    public float horizontalInput;
    public float verticalInput;

    
    Animator anim;
    void Start()
    {
        player = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        anim = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up * horizontalInput * walkingSpeed / 2);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * walkingSpeed);

        if (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Vertical") > 0 || Input.GetAxis("Horizontal") < 0 || Input.GetAxis("Vertical") < 0)
        {
           anim.SetInteger("condition", 1);
        }
        else anim.SetInteger("condition", 0);

       
        
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("Level3");
                GameOver.IsGameOver = false;
            }
        if (Input.GetKey(KeyCode.X))
        {
            controls.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            keyCam.SetActive(false);
            keyText.SetActive(false);
            
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            doorCam.SetActive(false);
            doorText.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        //if (GameOver.IsGameOver) { player.simulated = false; }//is suppose to freeze player inplace.
    }
    
    
}
