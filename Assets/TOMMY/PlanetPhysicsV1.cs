using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetPhysicsV1 : MonoBehaviour
{
    // Source
    // https://www.physicsforums.com/insights/orbital-mechanics-in-unity-game-engine-for-augmented-reality/

    [Header("Sun Properties")]
    public Transform sun;
    public Rigidbody sunPhysics;

    // Scales
    // Planets are 1/1,000,000 scale (but correct proportionally) - so instead of 12742km earth is 12.742m
    // Weights are relative to earth (earth weighs 1, sun weighs 333054.3 times more than earth so it's value is 333054.3). 

    Rigidbody thisRb;

    public int scaleFactor = 1000000000;


    // Start is called before the first frame update
    void Start()
    {
        thisRb = GetComponent<Rigidbody>();
        thisRb.AddForce(Vector3.left * scaleFactor * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        var dist = Vector3.Distance(this.transform.position, sun.position);
        var directionForce = (sun.position - this.transform.position) / dist;
        var forceValue = (sunPhysics.mass * thisRb.mass) / Mathf.Pow(dist, 2);
        var force = 1 * forceValue * directionForce;
        thisRb.AddForce(force);

        /*if(Input.GetKey(KeyCode.UpArrow))
        {
            scaleFactor = scaleFactor * 2;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            scaleFactor = scaleFactor / 2;
        }*/

        thisRb.AddForce(Vector3.left * scaleFactor * Time.deltaTime);
    }
}
