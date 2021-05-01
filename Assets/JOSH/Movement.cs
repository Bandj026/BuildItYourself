using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR.InteractionSystem;

public class Movement : MonoBehaviour
{
    private Animator _ParticleAnimator;
    public LinearMapping linearMapping;
    public float value;
    private float multiplier = 2;
    // Start is called before the first frame update
    void Start()
    {
        _ParticleAnimator = GetComponent<Animator>();

        if (linearMapping == null)
        {
            linearMapping = GetComponent<LinearMapping>();
        }

        if (linearMapping == null)
        {
            linearMapping = gameObject.AddComponent<LinearMapping>();
        }
        value = linearMapping.value;

    }

    // Update is called once per frame
    void Update()
    {
        value = (linearMapping.value*multiplier);
        _ParticleAnimator.speed = value;
        MoveParticle();
    }

    private void MoveParticle()
    {
        _ParticleAnimator.SetTrigger("ParticleStart");
        _ParticleAnimator.SetFloat("Speed", value); 

    }
}
