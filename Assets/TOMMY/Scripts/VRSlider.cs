using UnityEngine;
using Valve.VR.InteractionSystem;
using UnityEngine.UI;

public class VRSlider : MonoBehaviour
{
    public LinearMapping linearMapping;
    public Scrollbar scrollbar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(linearMapping.value != scrollbar.value)
        {
            scrollbar.value = linearMapping.value;
        }
    }
}
