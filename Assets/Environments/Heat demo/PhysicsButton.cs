using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class PhysicsButton : MonoBehaviour
{
    [SerializeField] private float threshold = 0.1f;
    [SerializeField] private float deadZone = 0.025f;

    private bool isPressed;
    private Vector3 startPosition;
    private ConfigurableJoint _joint;


    public UnityEvent onPressed;
    public UnityEvent onReleased;
    public static event Action onButtonPressed;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.localPosition;
        _joint = GetComponent<ConfigurableJoint>();
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (!isPressed && GetValue() + threshold >= 1)
        {
            Pressed();
        }
        if (isPressed && GetValue() - threshold <= 0)
        {
            Released();
        }*/
        
    }

    private float GetValue()
    {
        var value = Vector3.Distance(startPosition, transform.localPosition) / _joint.linearLimit.limit;
        if(Mathf.Abs(value) < deadZone)
        {
            value = 0;
        }
        return Mathf.Clamp(value, -1f, 1f);
    }
    /*
    private void Pressed()
    {
        isPressed = true;
        Debug.Log("Pressed 1");
        onPressed.Invoke();
        onButtonPressed?.Invoke();
        //Debug.Log("Pressed 2");
    }

    private void Released()
    {
        isPressed = false;
        Debug.Log("Released");
        onReleased.Invoke();
    }*/
}
