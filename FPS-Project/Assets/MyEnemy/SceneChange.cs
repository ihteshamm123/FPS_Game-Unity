using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    //   public void TimeOver()
    //  {
    //}
	void Start()
    	{
     	   Cursor.visible =true;
    	}

    public void FirstLevel()
    {
        Debug.Log("first Level!");
        SceneManager.LoadScene("Haris");
    }
    public void Restart()
    {
        Debug.Log("Restart!");
        SceneManager.LoadScene("Menu");
    }
    public void SndLevel()
    {
        Debug.Log("2nd Level!");
        SceneManager.LoadScene("Ihtesham");
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
