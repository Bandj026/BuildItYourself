using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Animator _ParticleAnimator;
    // Start is called before the first frame update
    void Start()
    {
        _ParticleAnimator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        PhysicsButton.onButtonPressed += MoveParticle;
        
    }

    private void MoveParticle()
    {
        _ParticleAnimator.SetTrigger("ParticleStart");

    }
}
