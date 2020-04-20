using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeControl : MonoBehaviour
{

    //Reference to audio source 
    private AudioSource Audio;
    private float mv = 1f;      //Start value for music volume

    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();        //Assign audio source
    }

    // Update is called once per frame
    void Update()
    {
        Audio.volume = mv;                      //Loop to update music volume
    }

    //Method called by the slider game object
    public void SetVolume(float vol)
    {
        mv = vol;
    }
}
