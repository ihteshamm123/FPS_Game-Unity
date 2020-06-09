using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public static int countDown = 40;
    // Start is called before the first frame update
    void Start()
    {
        CountDownTimer();
    }

    void CountDownTimer()
    {
        if (countDown > 0)
        {
            print("Timer is : " + countDown);
            countDown--;
            Invoke("CountDownTimer", 1.0f);
        }
        else
        {
            print("Game Over!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
