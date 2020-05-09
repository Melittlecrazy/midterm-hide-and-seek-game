using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject hasKey;
    public GameObject door;
    public GameObject doorCam;
    public GameObject doorText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            transform.position = transform.position + new Vector3(0, -2, 0);
            hasKey.SetActive(true);
            door.SetActive(true);
            doorCam.SetActive(true);
            doorText.SetActive(true);
        }
    }
}
