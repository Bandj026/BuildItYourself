using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DroneFlyPhysics : MonoBehaviour
{

    // Attempting following coding conventions.
    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions.

    public Slider engineSpeed;

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
        foreach(Transform engine in engines)
        {
            engine.Rotate(Vector3.forward * 15000 * 2.5f * engineSpeed.value * Time.deltaTime);
        }
    }
    // for updating physics (prevents framerate-limited physics issues)
    private void FixedUpdate()
    {
        foreach (Transform engine in engines)
        {
            rb.AddForceAtPosition(engine.forward * engineSpeed.value * 4.5f, engine.position);
        }
    }
}
