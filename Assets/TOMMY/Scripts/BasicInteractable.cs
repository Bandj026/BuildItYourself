using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

[RequireComponent( typeof(Interactable))]
public class BasicInteractable : MonoBehaviour
{
    // a simplification of InteractableExample.cs, sample code provided by Valve

    //public bool returnToSpecificPosition = true;
    //public Vector3 positionToReturnTo = Vector3.zero;

    public bool currentlyHeld = false;

    // place to return object to when the user lets go of it
    private Vector3 oldPosition;
    private Quaternion oldRotation;


    // needed to keep track of what the user's hands are doing
    private Hand.AttachmentFlags attachmentFlags = Hand.defaultAttachmentFlags & (~Hand.AttachmentFlags.SnapOnAttach) & (~Hand.AttachmentFlags.DetachOthers) & (~Hand.AttachmentFlags.VelocityMovement);
    private Interactable interactable;

    // Start is called before the first frame update
    void Start()
    {
        interactable = GetComponent<Interactable>();
    }

    //-------------------------------------------------
    // Called when a Hand starts hovering over this object
    //-------------------------------------------------
    private void OnHandHoverBegin(Hand hand)
    {
    }


    //-------------------------------------------------
    // Called when a Hand stops hovering over this object
    //-------------------------------------------------
    private void OnHandHoverEnd(Hand hand)
    {
    }

    private void HandHoverUpdate(Hand hand)
    {
        GrabTypes startingGrabType = hand.GetGrabStarting();
        bool isGrabEnding = hand.IsGrabEnding(this.gameObject);

        if (interactable.attachedToHand == null && startingGrabType != GrabTypes.None)
        {
            // Save our position/rotation so that we can restore it when we detach
            oldPosition = transform.localPosition;
            oldRotation = transform.localRotation;

            // Call this to continue receiving HandHoverUpdate messages,
            // and prevent the hand from hovering over anything else
            hand.HoverLock(interactable);

            // Attach this object to the hand
            hand.AttachObject(gameObject, startingGrabType, attachmentFlags);

            // notify other scripts that this object has been picked up
            currentlyHeld = true;
        }
        else if (isGrabEnding)
        {
            // Detach this object from the hand
            hand.DetachObject(gameObject);

            // Call this to undo HoverLock
            hand.HoverUnlock(interactable);

            // Restore position/rotation
            transform.localPosition = oldPosition;
            transform.localRotation = oldRotation;

            // notify other scripts that this object is no longer held.
            currentlyHeld = false;
        }
    }

    //-------------------------------------------------
    // Called when this GameObject becomes attached to the hand
    //-------------------------------------------------
    private void OnAttachedToHand(Hand hand)
    {
    }



    //-------------------------------------------------
    // Called when this GameObject is detached from the hand
    //-------------------------------------------------
    private void OnDetachedFromHand(Hand hand)
    {
    }


    //-------------------------------------------------
    // Called every Update() while this GameObject is attached to the hand
    //-------------------------------------------------
    private void HandAttachedUpdate(Hand hand)
    {
    }

    //-------------------------------------------------
    // Called when this attached GameObject becomes the primary attached object
    //-------------------------------------------------
    private void OnHandFocusAcquired(Hand hand)
    {
    }


    //-------------------------------------------------
    // Called when another attached GameObject becomes the primary attached object
    //-------------------------------------------------
    private void OnHandFocusLost(Hand hand)
    {
    }
}
