using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUps : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Pick Up")) {
			Destroy (other.gameObject);
//			other.gameObject.SetActive(false);
		}
	}
		
}
