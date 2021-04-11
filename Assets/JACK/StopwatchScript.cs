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
using Debug=UnityEngine.Debug;

public class StopwatchScript : MonoBehaviour
{

    public Text txt;
    public Stopwatch timer = new Stopwatch();

    private void Awake()
    {
        //m_CharacterController = GetComponent<CharacterController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        //m_CameraRig = SteamVR_Render.Top().origin;
        //m_Head = SteamVR_Render.Top().head;
    }

    // Update is called once per frame
    void Update()
    {
        /*#region Vector2 Action
        Vector2 delta = m_TouchPosition[SteamVR_Input_Sources.LeftHand].delta;
        if (delta.x >= (m_NeutralPosition.x + m_deadzone.x) && delta.y >= (m_NeutralPosition.y + m_deadzone.y))
        {
            Debug.Log("Player is moving right and up");
        }
        #endregion

        txt.text = delta.y.ToString();
	txt.text = "hi there";*/
	TimeSpan ts = timer.Elapsed;
	txt.text = ts.ToString();
    }

    public void testTime(Hand fromHand)
    {
        txt.text = "you did it!";
    }

    public void Start(Hand fromHand)
    {
        timer.Start();
    }
    public void Stop(Hand fromHand)
    {
        timer.Stop();
    }
    public void Reset(Hand fromHand)
    {
        timer.Stop();
	timer.Restart();
    }
}