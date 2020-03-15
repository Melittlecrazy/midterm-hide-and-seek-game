using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerControl : MonoBehaviour
{
    private int walkingSpeed= 9;
    private Rigidbody player;
    public float jumpForce;
    public float gravityModifier;

    public float horizontalInput;
    public float verticalInput;

    void Start()
    {
        player = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up * horizontalInput * walkingSpeed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * walkingSpeed);
     

        if (Input.GetKeyDown(KeyCode.Space)){player.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);}

        if (GameOver.IsGameOver) {  }//is suppose to freeze player inplace.
    }
}
