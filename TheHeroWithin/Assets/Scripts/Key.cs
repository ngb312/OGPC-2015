using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {
	public GameObject GameManager;
	public GameObject Victim;
	public GameObject Cage;

	void OnTriggerEnter(Collider co)
	{
		if (co.tag == "Key") 
		{
			Destroy(co.gameObject);
			Destroy(Victim);
			Destroy (Cage);
			var score = GameManager.GetComponent<Score> ();
			score.FlagFoundVicitm1();
		}
	}
}
