using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOptions : MonoBehaviour
{
     
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Title");
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    public void LoadScene()
    {
        SceneManager.LoadScene("Level1");

    }
    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
        
    }

    public void ReturnToTitle()
    {
        
        SceneManager.LoadScene("Title");
    }
}
