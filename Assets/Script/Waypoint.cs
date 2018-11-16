using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Waypoint : MonoBehaviour {

	public Transform[] enemy;

	public float speed;
	private int current;




	// Use this for initialization
	void Start () {

		   


	}


	// Update is called once per frame
	void Update () {

		//transform.Translate = Vector3.MoveTowards;



	
		if (transform.position != enemy [current].position) {
			Vector3 pos = Vector3.MoveTowards (transform.position, enemy [current].position, speed * Time.deltaTime);
			GetComponent<Rigidbody> ().MovePosition (pos);

		

		} else
			current = (current + 1) % enemy.Length;


	}

}