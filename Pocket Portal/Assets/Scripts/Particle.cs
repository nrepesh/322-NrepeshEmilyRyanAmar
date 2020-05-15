using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public ParticleSystem _psystem;
    // Start is called before the first frame update
    void Start()
    {
         _psystem = GetComponent<ParticleSystem>();
    }

    void OnTriggerEnter(Collider other)
{
    if (other.gameObject.tag == "MainCamera")
    {
        _psystem.Play();
    }
}

}
