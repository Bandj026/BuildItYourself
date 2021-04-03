using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GravityControlConsole : MonoBehaviour
{

    //public List
    public Transform planetModel;
    public TextMeshProUGUI planetName;
    public List<Planet> planets;

    public void ChangePlanetSelection(int id)
    {
        Planet planet = planets[id];
        planetName.text = planet.name;
        planetModel.localScale = planet.scale;
        planetModel.GetComponent<MeshRenderer>().material = planet.mat;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
