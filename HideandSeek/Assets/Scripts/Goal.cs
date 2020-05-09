using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public GameObject key;
    public GameObject keyText;
    public GameObject pointLight;



    public Text score;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player" && !GameOver.IsGameOver)
        {
            count = count + 1;
            score.text = "Souls: " + count.ToString() + "/5";
            if (count == 1)
            {
                transform.position = transform.position + new Vector3(22, 0, -18);
            }
            else if (count == 2)
            {
                transform.position = transform.position + new Vector3(0, 0, 35);
            }
            else if (count == 3)
            {
                transform.position = transform.position + new Vector3(-12, 0, -15);
            }
            else if (count == 4)
            {
                transform.position = transform.position + new Vector3(-20, 0, 15);
            }
            if (count == 5)
            {
                key.SetActive(true);
                keyText.SetActive(true);
                transform.position = transform.position + new Vector3(0, -5, 0);
            }
            //gameObject.GetComponent<Renderer>().enabled = false;
            //gameObject.GetComponent<Collider>().enabled = false;
        }
    }
   

    void Update()
    {
        
    }
}
