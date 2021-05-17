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

    // for when using the VR controller
    public Vector2 movementDir;
    public float throttle;


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
        if(usingSlider)
        {
            movementDir = new Vector2(movementXDir.value, movementZDir.value);
            throttle = engineSpeed.value;
        }

        foreach(Transform engine in engines)
        {
            engine.Rotate(Vector3.forward * 15000 * 2.5f * throttle * Time.deltaTime);
        }        
        
    }
    // for updating physics (prevents framerate-limited physics issues)
    private void FixedUpdate()
    {
        if (rb.velocity.magnitude > 0.1f & throttle > 0.4f)
        {
            rb.rotation = Quaternion.Euler(movementDir.x * 30, 0, movementDir.y * 30);
        }

        foreach (Transform engine in engines)
        {
            rb.AddForceAtPosition(engine.forward * throttle * 4.5f, engine.position);
        }
    }
}
