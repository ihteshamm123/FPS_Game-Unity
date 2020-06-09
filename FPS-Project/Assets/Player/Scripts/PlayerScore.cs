using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public static int SCORE = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Bullet(Clone)")
        {
            print("Colliding Object with bullet !");
            SCORE = SCORE + 10;
            print("Follow player Score : " + SCORE);
        }
    }
}