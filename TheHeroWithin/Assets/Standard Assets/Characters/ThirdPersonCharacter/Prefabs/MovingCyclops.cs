 using UnityEngine;
using System.Collections;

public class MovingCyclops : MonoBehaviour {
	public Vector3 currentDirection;
	public GameObject[] PatrolPoints;
	int currentPatrol;
	public int Speed;
	public bool isInCage;


	// Update is called once per frame
	void Update () {
		//print ("patrol points length:" + PatrolPoints.Length);
		//print ("currentPatrol" + currentPatrol);
		if (isInCage == false) {
			transform.position = Vector3.MoveTowards (transform.position, PatrolPoints [currentPatrol].transform.position, Speed * Time.deltaTime);
		}
	}
	
	public void CheckAndMove(GameObject collisionObject)
	{
		currentPatrol++;
		transform.Rotate (0, 90, 0);
		if (currentPatrol == PatrolPoints.Length) 
		{
			currentPatrol = 0;
		}
	}
}
