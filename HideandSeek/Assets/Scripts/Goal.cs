using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public GameObject winText;
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
            score.text = "Score: " + count.ToString();
            if (count == 1)
            {

                transform.position = transform.position + new Vector3(22,0,-18);
            }
            else if (count == 2)
            {
                transform.position = transform.position + new Vector3(0,0,35);
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
                winText.SetActive(true);
            }
            //gameObject.GetComponent<Renderer>().enabled = false;
            //gameObject.GetComponent<Collider>().enabled = false;
            //pointLight.SetActive(false);
        }
    }
   

    void Update()
    {
        
    }
}
