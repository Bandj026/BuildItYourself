using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR.InteractionSystem;

public class PendulumMassDriver : MonoBehaviour
{
    public Text txt;
    public Rigidbody rigidbody;
    public LinearMapping linearMapping;
    public float value = 50;

    private float oldValue = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        if (linearMapping == null)
        {
            linearMapping = GetComponent<LinearMapping>();
        }

        if (linearMapping == null)
        {
            linearMapping = gameObject.AddComponent<LinearMapping>();
        }

        rigidbody = GetComponent<Rigidbody>();
        value = linearMapping.value;
    }

    // Update is called once per frame
    void Update()
    {
        if(linearMapping.value != oldValue) // done to improve performance
        {
            value = (int)(linearMapping.value * 100);
            txt.text = "Bulb Mass: " + value.ToString();
            //txt.text = "hello";
            rigidbody.mass = value;
            oldValue = linearMapping.value;
        }
        
    }
}
