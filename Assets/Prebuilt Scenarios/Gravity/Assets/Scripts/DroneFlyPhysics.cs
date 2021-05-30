using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DroneFlyPhysics : MonoBehaviour
{

    // Attempting following coding conventions.
    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions.

    public Slider engineSpeed;
    public Slider movementXDir;
    public Slider movementZDir;

    public bool usingSlider = true;
    public bool constructionMode = true;

    // for when using the VR controller
    public Vector2 movementDir;
    public float throttle;


    [Header("Components Attached")]
    public GameObject battery;
    public GameObject engine;
    public GameObject prop;
    public GameObject engineAssembly;
    // we don't need to know if the casing is connected because it doesn't effect functionality.

    private Rigidbody rb;

    public Transform[] engines;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(battery.activeSelf == true || !constructionMode)
        {
            Debug.Log("Battery Active!");
            // get input from slider
            if (usingSlider)
            {
                movementDir = new Vector2(movementXDir.value, movementZDir.value);
                throttle = engineSpeed.value;
            }

            // check status of all components

            // apply propellor rotation animation (propellor rotation speed tied to throttle)
            //foreach (Transform engine in engines)
            // changed to individual as we now have to check for 3 of the 4 if the prop should activate based on if it's components are attached.
            if(engineAssembly.activeSelf || !constructionMode)
            {
                Debug.Log("engine assembly connected");
                engines[0].Rotate(Vector3.forward * 15000 * 2.5f * throttle * Time.deltaTime);
            }
            if(prop.activeSelf || !constructionMode)
            {
                Debug.Log("prop connected");
                engines[1].Rotate(Vector3.forward * 15000 * 2.5f * throttle * Time.deltaTime);
            }
            engines[2].Rotate(Vector3.forward * 15000 * 2.5f * throttle * Time.deltaTime);
            if(engine.activeSelf || !constructionMode)
            {
                Debug.Log("engine connected");
                engines[3].Rotate(Vector3.forward * 15000 * 2.5f * throttle * Time.deltaTime);
            }
            


            //}
        }
             
        
    }
    // for updating physics (prevents framerate-limited physics issues)
    private void FixedUpdate()
    {
        if (battery.activeSelf == true || !constructionMode)
        {
            // if there is enough throttle and the drone is moving, allow directional movement
            if (rb.velocity.magnitude > 0.1f & throttle > 0.4f)
            {
                // rotate the drone based on the thumbstick input
                rb.rotation = Quaternion.Euler(movementDir.x * 30, 0, movementDir.y * 30);
            }
            if(engineAssembly.activeSelf && prop.activeSelf && engine.activeSelf)
            {
                rb.AddForce(transform.up * throttle * 4.5f * 4); // quick cheat to solve the imbalance issue
            } else
            {
                if (engineAssembly.activeSelf || !constructionMode)
                {
                    rb.AddForceAtPosition(engines[0].forward * throttle * 4.5f, engines[0].position); ;
                }
                if (prop.activeSelf || !constructionMode)
                {
                    rb.AddForceAtPosition(engines[1].forward * throttle * 4.5f, engines[1].position);
                }
                rb.AddForceAtPosition(engines[2].forward * throttle * 4.5f, engines[2].position);
                if (engine.activeSelf || !constructionMode)
                {
                    rb.AddForceAtPosition(engines[3].forward * throttle * 4.5f, engines[3].position);
                }
            }
            

            /*foreach (Transform engine in engines)
            {
                // using physics, add force in the upwards direction from the perspective of each propellor location, with the force amount tied to the throttle.
                rb.AddForceAtPosition(engine.forward * throttle * 4.5f, engine.position);
            }*/
        }
    }
}
