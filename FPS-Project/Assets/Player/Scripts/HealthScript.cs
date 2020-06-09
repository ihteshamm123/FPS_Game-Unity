using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public static float health;
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

        if (other.gameObject.name == "Ethan(Clone)")
        {
            print("Colliding!");
            health = health - 10;
            print("Health : " + health);
        }
        print("Health : " + other.gameObject);
        if (health == 10)
        {
            Application.Quit();
        }

    }
}
