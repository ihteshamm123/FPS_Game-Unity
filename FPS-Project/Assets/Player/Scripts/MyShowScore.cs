using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MyShowScore : MonoBehaviour
{
    public Text playerscore;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerscore.text = "Score : " + PlayerScore.SCORE;
    }
}