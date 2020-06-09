using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
public class ShowScore : MonoBehaviour
{
    public Text ScoreSh;
    //public followPlayer.Score sc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreSh.text = "Score : " + followPlayer.SCORE;
        
    }
}
