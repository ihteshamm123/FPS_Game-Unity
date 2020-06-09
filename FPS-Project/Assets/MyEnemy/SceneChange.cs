using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    //   public void TimeOver()
    //  {
    //}

    public void FirstLevel()
    {
        Debug.Log("first Level!");
        Application.LoadLevel("Haris");
    }
    public void Restart()
    {
        Debug.Log("Restart!");
        Application.LoadLevel("Menu");
    }
    public void SndLevel()
    {
        Debug.Log("2nd Level!");
        Application.LoadLevel("Ihtesham");
    }

    void Update()
    {
           /* if (Timer.countDown == 0)
            {
                print(" Time Up! ");
                Application.LoadLevel("EndGame");
            }
            if (Attack.health == 0 ) 
            {
                print("Killed!");
                Application.LoadLevel("EndGame");
            }*/
    }
    public void exitgame()
    {
        Debug.Log("Game Over!");
        Application.Quit();
    }
}
