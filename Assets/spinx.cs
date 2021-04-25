using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinx : MonoBehaviour
{
    Light Awake()
    {
        Light myLight = GameObject.Find("PointLight").GetComponent<Light>();
        return myLight;
    }

    Light Awake2()
    {
        Light myLight = GameObject.Find("SpotLight").GetComponent<Light>();
        return myLight;
    }

    Light Awake3()
    {
        Light myLight = GameObject.Find("SpotLight2").GetComponent<Light>();
        return myLight;
    }




    void FixedUpdate()
    {
        Light myLight = Awake();
        Light myLight2 = Awake2();
        Light myLight3 = Awake3();
        ///Debug.Log("The light is" + myLight.enabled);

        if (myLight.enabled == true && myLight2.enabled == true && myLight3.enabled == true) {
            Debug.Log("WANNA SPIN");
            transform.Rotate(new Vector3(0f, 0f, 300f) * Time.deltaTime);
        }

        
    }


}