using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class StopwatchScript : MonoBehaviour
{
    /*//Variable for grabbing the desired actionset
    public SteamVR_ActionSet m_ActionSet;
    // varaibles for storing if the touchpads have been used on the controller
    public SteamVR_Action_Vector2 m_TouchPosition;
    // varaible for storing player speed
    private float m_Speed = 0.0f;
    // varaible for storing the character controller
    private CharacterController m_CharacterController = null;
    //location values for the player position and the head position
    private Transform m_CameraRig = null;
    private Transform m_Head = null;
    //sets the deadzone for how far the player needs to move their thumb before
    public Vector2 m_deadzone = new Vector2(0.1f, 0.1f);
    public Vector2 m_NeutralPosition = new Vector2(0.0f, 0.0f);*/



    public Text txt;

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
    }

    public void testTime(Hand fromHand)
    {
        txt.text = "you did it!";
    }
}