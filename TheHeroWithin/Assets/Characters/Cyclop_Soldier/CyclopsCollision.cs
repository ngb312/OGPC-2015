using UnityEngine;
using System.Collections;

public class CyclopsCollision : MonoBehaviour {

	public MovingCyclops Cyclops;	

	void OnTriggerEnter (Collider co)
	{
		print ("On Trigger Enter" + co.tag);
		if (co.tag == "Patrol1") 
		{
			Cyclops.CheckAndMove(co.gameObject);
		}
		else if (co.tag == "Patrol2") 
		{
			Cyclops.CheckAndMove(co.gameObject);
		}
		else if (co.tag == "Patrol3") 
		{
			Cyclops.CheckAndMove(co.gameObject);
		}
		else if (co.tag == "Patrol4") 
		{
			Cyclops.CheckAndMove(co.gameObject);
		}
	}
}

