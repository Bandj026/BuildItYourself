using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR;
using Valve.VR.InteractionSystem;
using Debug = UnityEngine.Debug;

public class StopwatchButtons : MonoBehaviour
{
    public StopwatchScript stopwatchScript;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void testTime(Hand fromHand)
    {
        stopwatchScript.txt.text = "you did it!";
    }

    public void Start(Hand fromHand)
    {
        stopwatchScript.timer.Start();
    }
    public void Stop(Hand fromHand)
    {
        stopwatchScript.timer.Stop();
    }
    public void Reset(Hand fromHand)
    {
        stopwatchScript.timer.Stop();
        stopwatchScript.timer.Restart();
        stopwatchScript.timer.Stop();
    }
}
