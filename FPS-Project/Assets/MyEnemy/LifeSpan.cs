using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSpan : MonoBehaviour
{   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.countDown == 0)
        {
            print(" Time Up! ");
            Application.LoadLevel("EndGame");
        }
        if (Attack.health == 0)
        {
            print("Killed!");
            Application.LoadLevel("EndGame");
        }
    }
}
