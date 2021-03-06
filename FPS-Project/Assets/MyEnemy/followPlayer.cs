﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.AI;
//using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class followPlayer : MonoBehaviour
{
    //public Text Scoretext;
    public static int SCORE = 0;
    private UnityEngine.AI.NavMeshAgent agent = null;
    public Transform destination = null;

    // Start is called before the first frame update
    void Start()
    {
	Cursor.visible = true;
	Time.timeScale = 1; 
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 20)
        {
            //Scoretext.Text = " " + SCORE;
            agent.SetDestination(destination.position);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Bullet(Clone)")
        {
            print("Colliding Object with bullet !");
            Destroy(other.gameObject);
            SCORE = SCORE + 10;
            print("Follow player Score : " + SCORE);
        }
        if (SCORE == 300)
        {
		Destroy(gameObject);
		Destroy(other.gameObject);
            SceneManager.LoadScene("Winning");
        }
    }
}
