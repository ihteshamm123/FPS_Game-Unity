using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MyPlayerHealth : MonoBehaviour
{
       public Text playerhealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerhealth.text = "Health : " + HealthScript.health;
    }
}
