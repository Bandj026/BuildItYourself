using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystemModel : MonoBehaviour
{

    public Transform sun;
    public float rotationSpeed = 10; // rotation speed (higher is faster) - 1 = 1 rotation/second
    public float orbitSpeed = 5; // orbit time (lower is faster), 1 = 1 orbit/sec, 2 = 1 orbit/2sec, etc.

    public bool isModel = false;

   //public BasicInteractable interactable;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!isModel)
        {
            transform.Rotate(Vector3.up, rotationSpeed * 360 * Time.deltaTime, Space.Self);
            if (orbitSpeed > 0)
            {
                transform.RotateAround(sun.position, Vector3.up, (360 / orbitSpeed) * Time.deltaTime);
            }
        } else
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.Self);
            if (orbitSpeed > 0)
            {
                transform.RotateAround(sun.position, Vector3.up, orbitSpeed * Time.deltaTime);
            }
        }
        
        
    }
}
