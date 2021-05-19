using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollisionLightOther : MonoBehaviour
{

    public GameObject light;

    bool touchedA = false;
    bool touchedB = false;

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Connector")
        {
            Debug.Log("Touching " + other.gameObject.name);
            if (other.gameObject.name == "Connector1")
            {
                touchedA = true;
            }
            else if(other.gameObject.name == "Connector2")
            {
                touchedB = true;
            } else
            {
                touchedA = false;
                touchedB = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Connector")
        {
            if (other.gameObject.name == "Connector1")
            {
                touchedA = false;
            }
            else if (other.gameObject.name == "Connector2")
            {
                touchedB = false;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (touchedA && touchedB)
        {
            light.SetActive(true);
        }
        else
        {
            light.SetActive(false);
        }
    }
}
