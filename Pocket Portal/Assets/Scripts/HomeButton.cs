using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeButton : MonoBehaviour
{
	public AudioSource audio;
	public AudioClip clip;


	public void changescene(string scenename)
	{
		StartCoroutine(PlaySound(scenename));
	}

	IEnumerator PlaySound(string scenename)
	{
		//Play the clip once
		audio.Play();

		//Wait until clip finish playing
		yield return new WaitForSeconds(clip.length); //play sound before opening / closing panels

		//change panels
		Application.LoadLevel(scenename);

	}
}
