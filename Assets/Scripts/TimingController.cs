using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimingController : MonoBehaviour {

    public Text myTimerText;
    public float timer;
    public float[] timingBreakpoints;
    public bool[] broke;

    // Use this for initialization
    void Start () {
        broke = new bool[timingBreakpoints.Length];
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        myTimerText.text = timer.ToString("0.##") + "s";
        int max = -1;
        for(int i = 0; i < timingBreakpoints.Length; i++)
        {
            if (timer >= timingBreakpoints[i])
            {
                max = i;
            }
        }
        if (max >= 0 && !broke[max])
        {
            broke[max] = true;
            print("Broke through breakpoint " + max);
        }
    }
}
