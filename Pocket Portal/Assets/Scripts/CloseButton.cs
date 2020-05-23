using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseButton : MonoBehaviour
{
    public Button button;
	public GameObject currentPanel;// current panel that will be closed
	public AudioSource audio;
	public AudioClip clip;

	// Start is called before the first frame update
	void Start()
	{
		Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		StartCoroutine(PlaySound());
	}

	IEnumerator PlaySound()
	{
		//Play the clip once
		audio.Play();

		//Wait until clip finish playing
		yield return new WaitForSeconds(clip.length); //play sound before opening / closing panels

		//change panels
		currentPanel.SetActive(false);

	}
}
