using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class DroneController : MonoBehaviour
{
    // this is an adaption of Valve's Buggy controller script, using it to control the drone.
    // controls will be trigger for drone engine speed (throttle), joystick for movement direction and the reset button for respawning the drone.

    // for animating the joystick, trigger and buttons (Parmeters)
    public Transform modelJoystick;
    public float joystickRot = 20;

    public Transform modelTrigger;
    public float triggerRot = 20;

    public Transform buttonReset;

    public DroneFlyPhysics drone;

    public Transform resetPos; // position to reset to

    // SteamVR Interaction System (get controller input values)
    public SteamVR_Action_Vector2 actionSteering = SteamVR_Input.GetAction<SteamVR_Action_Vector2>("drone", "Steering");

    public SteamVR_Action_Single actionThrottle = SteamVR_Input.GetAction<SteamVR_Action_Single>("drone", "Throttle");

    public SteamVR_Action_Boolean actionReset = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("drone", "Reset");

    // detect if user is holding controller
    private Interactable interactable;

    // for animation of the joystick and trigger based on player inputs (actual rotation values)
    private Quaternion trigSRot;
    private Quaternion joySRot;

    // Start is called before the first frame update
    void Start()
    {
        joySRot = modelJoystick.localRotation;
        trigSRot = modelTrigger.localRotation;

        interactable = GetComponent<Interactable>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 steer = Vector2.zero;

        float throttle = 0;
        bool reset = false;
        bool b_reset = false;

        // get the inputs from the steamVR input system
        if (interactable.attachedToHand)
        {
            SteamVR_Input_Sources hand = interactable.attachedToHand.handType;

            steer = actionSteering.GetAxis(hand);
            throttle = actionThrottle.GetAxis(hand);
            b_reset = actionReset.GetState(hand);
            reset = actionReset.GetStateDown(hand);
        }

        // animate the joystick
        modelJoystick.localRotation = joySRot;
        modelJoystick.Rotate(steer.y * -joystickRot, steer.x * -joystickRot, 0, Space.Self);
        modelTrigger.localRotation = trigSRot;
        modelTrigger.Rotate(throttle * -triggerRot, 0, 0, Space.Self);
        buttonReset.localScale = new Vector3(1, 1, b_reset ? 0.4f : 1.0f);

        // apply values to the drone
        drone.throttle = throttle;
        drone.movementDir = steer;

        if(reset)
        {
            Reset();
        }
    }

    private void Reset()
    {
        drone.throttle = 0;
        drone.movementDir = Vector2.zero;
        drone.transform.position = resetPos.position;
        drone.transform.rotation = resetPos.rotation;
    }
}
