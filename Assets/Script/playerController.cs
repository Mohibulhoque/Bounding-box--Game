using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
	public float speed = 10.0f;
	public float rotationSpeed = 100.0f;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

	
		float translation = Input.GetAxis("Vertical") * speed;
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed;


		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;


		transform.Translate(0, 0, translation);
		transform.Rotate(0, rotation, 0);
       
	}

    /*
	void OnCollisionEnter(Collision other)
	{	 


		if (other.gameObject.tag == "enemy") 
		{
			Debug.Log ("Done");
			Destroy(gameObject);
		}



	}

    */

}
