using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;


public class AttatchObject : MonoBehaviour
{
    public GameObject EnableThis;
    public string objectName;

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
        if (other.gameObject.name.Equals(objectName)) {
            EnableThis.SetActive(true);
            Debug.Log("Deleted game object ");
            other.GetComponent<Throwable>().enabled = false;
            other.GetComponent<Interactable>().enabled = false;
            Destroy(other.transform.gameObject);
        }




    }

}
