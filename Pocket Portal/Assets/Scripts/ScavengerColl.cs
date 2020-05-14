using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScavengerColl : MonoBehaviour
{
public AudioClip sound;
private AudioSource audioSource;
public ParticleSystem _psystem;

void Start ()   
     {
         GetComponent<AudioSource> ().playOnAwake = false;
         _psystem = GetComponent<ParticleSystem>();
     }  


void OnTriggerEnter(Collider other)
{
    if (other.gameObject.tag == "MainCamera")
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = sound;
        audioSource.Play();
        _psystem.Play();
        Destroy(gameObject, 0.5f);
    }
}

}

 
         
 
