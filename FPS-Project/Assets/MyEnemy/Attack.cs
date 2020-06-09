using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public static float health ;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Ethan(Clone)") {
            print("Colliding!");
        health = health - 25;
            print("Health : " + health);
    }
        print("Attack-Health : " + other.gameObject) ;
        if (health == 10)
        {
            //Time.timeScale = 0;
            Application.Quit();
        }
        else 
        {
          
           
            //col.gameObject.SetActiveRecursively(true);
        }

    }
    }
