using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScavengerColl : MonoBehaviour
{
	public AudioClip sound;
	private AudioSource audioSource;
	private static int Score = 0;
	private int winScore = 3; //max items to find
	public Text ScoreText;
	public GameObject winPanel;

	void Start()
	{
		//Score = 0;
		SetScoreText();
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "MainCamera")
		{
			audioSource = GetComponent<AudioSource>();
			audioSource.clip = sound;
			audioSource.Play();
			Destroy(gameObject, 0.75f);

			//Score update
			Score = Score + 1;
			SetScoreText();

			if (Score == winScore) //opening win panel
			{
				StartCoroutine(OpenWinScreen());
			}
		}
	}

	void SetScoreText()
	{
		ScoreText.text = Score.ToString() + " / " + winScore;
	}

	IEnumerator OpenWinScreen()
	{
		yield return new WaitForSeconds(0.7f); //wait for particle effect to play
		winPanel.SetActive(true); //open win screen

	}


}




