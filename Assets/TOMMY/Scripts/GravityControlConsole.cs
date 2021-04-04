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

    public TextMeshProUGUI gravityDisplay;

    int currentSelection = 3;

    public void ChangePlanetSelection(int id)
    {
        Planet planet = planets[id];
        currentSelection = id;
        planetName.text = planet.name;
        planetModel.localScale = planet.scale;
        planetModel.GetComponent<MeshRenderer>().material = planet.mat;
    }

    public void ChangeGravity()
    {
        float gravity = planets[currentSelection].gravity;
        // set the gravity to the correct value for this planet
        Physics.gravity = new Vector3(0, gravity, 0);

        // show this value on the display
        // calc Gs
        float gs = Mathf.Abs(gravity / 9.81f);
        gravityDisplay.text = gs.ToString("F2") + "G (" + gravity + "ms^-2)";
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
