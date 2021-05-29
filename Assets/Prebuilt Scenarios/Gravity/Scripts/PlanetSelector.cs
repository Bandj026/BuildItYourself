using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlanetSelector : MonoBehaviour
{
    // this script loads the to-scale solar system model
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadModel()
    {
        Debug.Log("Loading Model..");
        SceneManager.LoadScene(2);
    }

    public void LoadLab()
    {
        Debug.Log("Loading Lab...");
        SceneManager.LoadScene(1);
    }
}
