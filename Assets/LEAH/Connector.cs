using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Connector : MonoBehaviour
{
    public ConnectorDetector lightA;
    public ConnectorDetector lightB;

    public ConnectorDetector FanA;
    public ConnectorDetector FanB;

    public GameObject lamp;
    public TextMeshProUGUI textUI;
    public GameObject fan;

    public conMaterial mat;

    // Update is called once per frame
    void Update()
    {
        if (lightA.connected == true && lightB.connected == true)
        {
            lamp.SetActive(true);
            
            if((lightA.something == this.gameObject && lightB.something == this.gameObject))
            {
                print(mat.mat);
                textUI.text = mat.mat;
            }

            if (FanA.connected == true && FanB.connected == true)
            {
                fan.transform.Rotate(new Vector3(0f, 0f, 150f) * Time.deltaTime, Space.Self);
            }

        } else
        {
            lamp.SetActive(false);
        }

        
    }


}
