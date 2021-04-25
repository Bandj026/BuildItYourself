using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connector : MonoBehaviour
{
    public ConnectorDetector lightA;
    public ConnectorDetector lightB;

    public ConnectorDetector FanA;
    public ConnectorDetector FanB;

    public GameObject lamp;
    public GameObject fan;

    // Update is called once per frame
    void Update()
    {
        if (lightA.connected && lightB.connected)
        {
            lamp.SetActive(true);
        } else
        {
            lamp.SetActive(false);
        }

        if(FanA.connected && FanB.connected)
        {
            fan.transform.Rotate(new Vector3(0f, 0f, 300f) * Time.deltaTime, Space.Self);
        }
    }
}
