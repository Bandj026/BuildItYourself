using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetDetector : MonoBehaviour
{

    public GameObject selectedPlanet;
    //public MeshRenderer selectedPlanet;
    MeshRenderer planetRenderer;
    BasicInteractable interactable;
    public bool planetDetected = false;

    //public Material defaultMat;

    private void Start()
    {
        planetRenderer = selectedPlanet.GetComponent<MeshRenderer>();
        interactable = selectedPlanet.GetComponent<BasicInteractable>();
        interactable.enabled = false; // if planet not set, pickup should be disabled.
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Planet")
        {
            planetDetected = true;
            Planet chosen = other.GetComponent<PlanetData>().planet;
            planetRenderer.material = chosen.mat;
            interactable.enabled = true;
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Planet")
        {
            planetDetected = false;
        }
    }
}
