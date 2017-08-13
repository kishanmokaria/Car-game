using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {
	public void PauseButtonClick(){
		Debug.Log ("Game was interruptted");
		if (Time.timeScale == 1.0f) {
			Time.timeScale = 0.0f; 

		}
		else if (Time.timeScale == 0.0f) {
			Time.timeScale = 1.0f;

		}
	
	}

}
