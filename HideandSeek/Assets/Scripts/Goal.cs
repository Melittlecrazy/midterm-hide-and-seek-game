using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public GameObject winText;
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
            score.text = "Score:" + count.ToString();
            if (count == 3)
            {
                winText.SetActive(true);
            }
            Destroy(this.gameObject);
        }
    }

    void Update()
    {
        
    }
}
