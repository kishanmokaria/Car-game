using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class logic : MonoBehaviour
{
	public GameObject mainmenu,gameplaymenu;
	public GameObject car,aicar;
	public Text scoreText;

	void Awake()
	{
		Time.timeScale = 0.0f;
	}

	//*IEnumerator Start()
	//*{
	//*	Debug.Log ("hello");
	//*	yield return new WaitForSeconds (5);
	//*	AudioSource[] carAudioSources =	car.GetComponents<AudioSource> ();
	//*	for(int i=0;i<carAudioSources.Length;i++)
	//*	{
	//*		carAudioSources [i].enabled = false;
	//*	}
	//*	carAudioSources =	aicar.GetComponents<AudioSource> ();
	//*	for(int i=0;i<carAudioSources.Length;i++)
	//*	{
	//*		carAudioSources [i].enabled = false;
	//*	}
		
	//*}


	// Use this for initialization
	public void PlayButtonClick ()
	{
		//Debug.Log("up");
		gameplaymenu.SetActive (true);
		mainmenu.SetActive (false);        
		Time.timeScale = 1.0f;                
	}
	
	void Update()
	{
		scoreText.text = Time.time.ToString("0.0");
	}
	
}

