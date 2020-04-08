using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceTimer : MonoBehaviour
{
    float timeToDance = 20;
    float dancing = 420;
    Animator anima;
    // Start is called before the first frame update
    void Start()
    {
        anima = GetComponent<Animator>();
        anima.SetInteger("Idel dance", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (dancing > 0)
        {
            dancing -= Time.deltaTime;
        }
        if (dancing < 0)
        {
            dancing = timeToDance;
           anima.SetInteger("Idel dance", 1);
           
           StopDancing();
        }
    }

    void StopDancing()
    {
        new DanceTimer();
    }
}
