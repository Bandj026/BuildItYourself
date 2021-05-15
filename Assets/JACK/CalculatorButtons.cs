using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR;
using Valve.VR.InteractionSystem;
using Debug = UnityEngine.Debug;

public class CalculatorButtons : MonoBehaviour
{
    public CalculatorScript calculatorScript;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void testText(Hand fromHand)
    {
        calculatorScript.txt.text = "you did it!";
    }

    public void one(Hand fromHand)
    {
        calculatorScript.txt.text = "you did it!";
    }

    public void two(Hand fromHand)
    {
        calculatorScript.txt.text = "you did it!";
    }
    public void three(Hand fromHand)
    {
        calculatorScript.txt.text = "you did it!";
    }
    public void four(Hand fromHand)
    {
        calculatorScript.txt.text = "you did it!";
    }
    public void five(Hand fromHand)
    {
        calculatorScript.txt.text = "you did it!";
    }
    public void six(Hand fromHand)
    {
        calculatorScript.txt.text = "you did it!";
    }
    public void seven(Hand fromHand)
    {
        calculatorScript.txt.text = "you did it!";
    }
    public void eight(Hand fromHand)
    {
        calculatorScript.txt.text = "you did it!";
    }
    public void nine(Hand fromHand)
    {
        calculatorScript.txt.text = "you did it!";
    }
    public void multiply(Hand fromHand)
    {
        calculatorScript.txt.text = "you did it!";
    }
    public void divide(Hand fromHand)
    {
        calculatorScript.txt.text = "you did it!";
    }
    public void add(Hand fromHand)
    {
        calculatorScript.txt.text = "you did it!";
    }
    public void subtract(Hand fromHand)
    {
        calculatorScript.txt.text = "you did it!";
    }
    public void equals(Hand fromHand)
    {
        calculatorScript.txt.text = "you did it!";
    }
    public void clear(Hand fromHand)
    {
        calculatorScript.txt.text = "you did it!";
    }
}
