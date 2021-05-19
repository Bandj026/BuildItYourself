using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class makeParent : MonoBehaviour

{

    public GameObject child1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start ");
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered ");
        
        
        if (other.gameObject.name ==  child1.name)
        {
            other.transform.parent = transform;
            child1.transform.position = new Vector3(-1, 0, -1);

            Debug.Log("The right object has entered ");
        }
    }


    


}

