using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectorDetector : MonoBehaviour
{
    //public bool connected = false;
    public bool connected;
    public GameObject something;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Connector")
        {
            connected = true;
            something = other.GetComponent<Collider>().transform.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Connector")
        {
            connected = false;
            something = other.GetComponent<Collider>().transform.gameObject;
        }
    }

}
