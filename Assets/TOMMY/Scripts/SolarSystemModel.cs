using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystemModel : MonoBehaviour
{

    public Transform sun;
    public float rotationSpeed = 10;
    public float orbitSpeed = 5;

   //public BasicInteractable interactable;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.Self);
        transform.RotateAround(sun.position, Vector3.up, orbitSpeed * Time.deltaTime);
    }
}
