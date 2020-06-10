using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeSpan : MonoBehaviour
{   
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible =true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.countDown == 0)
        {
            print(" Time Up! ");
            SceneManager.LoadScene("EndGame");
        }
        if (Attack.health == 0)
        {
            print("Killed!");
            SceneManager.LoadScene("EndGame");
        }
    }
}
