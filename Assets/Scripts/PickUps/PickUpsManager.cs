﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpsManager : MonoBehaviour {

	public float Duration;
	public float Life;
	public GameObject PickUp;
	public PlayerHealth playerHealth;
	public float spawnTime = 5f;
	public Transform[] spawnPoints;

	// Use this for initialization
	void Start () {

		InvokeRepeating ("Spawn", spawnTime, spawnTime);
		
	}


	// Update is called once per frame
	void Spawn ()
	{
		if(playerHealth.currentHealth <= 0f)
		{
			return;
		}

		int spawnPointIndex = Random.Range (0, spawnPoints.Length);


		Instantiate (PickUp, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
			

	}
}
