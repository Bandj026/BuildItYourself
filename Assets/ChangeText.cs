using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeText : MonoBehaviour
{

    public Text ChangingText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TextChange() {


        ChangingText.text = "6.30x10^7";

    }
}
