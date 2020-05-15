using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScavengerColl : MonoBehaviour
{
public AudioClip sound;
private AudioSource audioSource;


void OnTriggerEnter(Collider other)
{
    if (other.gameObject.tag == "MainCamera")
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = sound;
        audioSource.Play();
        Destroy(gameObject, 0.65f);
    }
}

}

 
         
 
