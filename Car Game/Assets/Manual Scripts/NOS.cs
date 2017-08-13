using UnityEngine;
using System.Collections;

public class NOS : MonoBehaviour {

	bool isReady  = true;
	GameObject vehicle;
	private float waitTime = 5.0f;
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown("left shift") && isReady){
         Nitrous();
     }
	
	}
	IEnumerator Nitrous(){
		isReady = false;
		gameObject.tag = "Player";
		gameObject.GetComponent<Rigidbody>().AddForce (transform.forward * 1000, ForceMode.Acceleration);
		//Camera.main.transform.position += (-Camera.main.transform.forward) * Time.deltaTime * 5;
		yield return new WaitForSeconds (waitTime);
		isReady = true;
		yield return null;
	}
}
