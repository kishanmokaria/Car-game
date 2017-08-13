using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	public GameObject target;
	private Transform t;

	// Use this for initialization
	void Start () {
		t = target.transform;
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (t.position.x-10,50,t.position.z-10);
	}
}
