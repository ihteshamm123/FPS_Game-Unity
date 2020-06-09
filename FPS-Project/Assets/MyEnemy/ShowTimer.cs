using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowTimer : MonoBehaviour
{
    public Text TimerSH;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimerSH.text = "TIMER : " + Timer.countDown;
    }
}
