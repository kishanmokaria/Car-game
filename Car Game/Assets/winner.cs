using UnityEngine;
using System.Collections;

public class winner : MonoBehaviour {
	void OnTriggerEnter(Collider col){
		//Debug.Log ("You Win");
		if (col.gameObject.tag == "Player" )
			Debug.Log ("You Win");
		else if (col.gameObject.tag == "Enemy" )
			Debug.Log ("You Lose");
	}

}
	
