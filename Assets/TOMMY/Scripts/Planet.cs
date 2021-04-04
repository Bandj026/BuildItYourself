using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Planet", menuName = "Create Planet Data")]
public class Planet : ScriptableObject
{
    public int id;
    public new string name;
    public Vector3 scale;
    public Material mat;
    public float gravity;

}
