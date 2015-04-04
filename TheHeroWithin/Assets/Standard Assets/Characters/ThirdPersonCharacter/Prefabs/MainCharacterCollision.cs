using UnityEngine;
using System.Collections;

public class MainCharacterCollision : MonoBehaviour {
	public GameObject cage;

	void OnTriggerEnter (Collider col)
	{
		print ("Main Character Trigger Enter" + col.tag);
		
		if (col.tag == "Cyclops") 
		{
			col.gameObject.transform.position = cage.transform.position;
			var movingcyclops = col.gameObject.GetComponent<MovingCyclops>();
			movingcyclops.isInCage = true;
			var cyclopsAnimation = col.gameObject.GetComponent<Animation>();
			cyclopsAnimation.Stop();
		
		}
	}
}
