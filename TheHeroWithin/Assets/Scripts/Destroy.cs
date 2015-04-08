using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
	public AudioClip trash;
	
	void OnTriggerEnter (Collider co)
	{
		print ("ontriggerenter :" + co.tag);
		print ("ontriggerenter gameobject:" + co.gameObject);
		if (co.tag.StartsWith ("Trash")) {
			Destroy (co.gameObject);
			print ("destroyed");
			var audio = GetComponent<AudioSource>();
			audio.PlayOneShot(trash);
		}
	
	}
	


}

 