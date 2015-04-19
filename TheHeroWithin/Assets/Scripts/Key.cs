﻿using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {
	public GameObject GameManager;
	public GameObject Victim;
	public GameObject Cage;
	public GameObject Picture;

	void OnTriggerEnter(Collider co)
	{
		if (co.tag == "Key") 
		{
			Destroy(co.gameObject);
			Destroy(Victim);
			Destroy (Cage);
			Destroy (Picture);
		}
	}
}
