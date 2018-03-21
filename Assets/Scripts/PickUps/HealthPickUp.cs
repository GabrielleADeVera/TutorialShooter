using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : MonoBehaviour {

	GameObject player;
	PlayerHealth playerHealth;
	GameObject pickup;

	void Awake(){
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent <PlayerHealth> ();
		pickup = GameObject.FindGameObjectWithTag ("Pick Up");

	}

	void OnTriggerEnter (Collider other)

	{
		if (other.gameObject == player) {
			playerHealth.TakeHealth (30);
		}

		if (other.gameObject == pickup) {
			Destroy (gameObject);
		}
	}
}
