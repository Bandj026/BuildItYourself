using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AttatchObject : MonoBehaviour
{
    public GameObject EnableThis;
    public string objectName;
    public GameObject deleteThis;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        ///Attatched to object you want to 
        if (other.name == deleteThis.name) {
            Destroy(deleteThis);

            EnableThis.SetActive(true);

            Debug.Log("Deleted game object ");
        }




    }

}
