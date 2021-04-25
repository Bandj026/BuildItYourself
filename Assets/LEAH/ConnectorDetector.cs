using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectorDetector : MonoBehaviour
{
    public bool connected = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Connector")
        {
            connected = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Connector")
        {
            connected = false;
        }
    }

}
