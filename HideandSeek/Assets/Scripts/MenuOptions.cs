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
    public void LoadScene()
    {
        SceneManager.LoadScene("Level");

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
