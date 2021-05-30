using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class makeParent : MonoBehaviour

{

    public GameObject childx;
    public Transform newParent;
    public float x;
    public float y;
    public float z;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start ");
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered ");
        
        
        
           // other.transform.parent = transform;
            childx.transform.SetParent(newParent);

            childx.transform.position = new Vector3(x, y, z);

            Debug.Log("The right object has entered ");

        //childx.GetComponent<BoxCollider>().enabled = false;
        // childx.GetComponent<Throwable>().enabled = false;
        //childx.Destroy(GetComponent<Throwable.cs>());
        //go.getComponent("component name").setActive(false);
        //Destroy(childx.GetComponent<Throwable>());
        //GameObject.Find("testChild").GetComponent<Throwable>().enabled = false;

    }


    


}

