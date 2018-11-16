using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	 
	public GameObject Gameplayer,life1,life2,life3,gameover;
	public static int health;
	public bool moveleft = false;
	//public GameObject effect;
	//public Vector3 pos ;


	// Use this for initialization
	void  Start () {
		
		health = 3;
		life1.gameObject.SetActive (true);
		life2.gameObject.SetActive (true);
		life3.gameObject.SetActive (true);
		gameover.gameObject.SetActive (false);



	}
	
	// Update is called once per frame
	void Update () {





		if (health > 3)
			health = 3;


		switch (health)

		{
		case 3:
			
			life1.gameObject.SetActive (true);
			life2.gameObject.SetActive (true);
			life3.gameObject.SetActive (true);
			break;
		case 2:
			life1.gameObject.SetActive (true);
			life2.gameObject.SetActive (true);
			life3.gameObject.SetActive (false);
			break;
		case 1:
			life1.gameObject.SetActive (true);
			life2.gameObject.SetActive (false);
			life3.gameObject.SetActive (false);
			break;

		case 0:
			life1.gameObject.SetActive (false);
			life2.gameObject.SetActive (false);
			life3.gameObject.SetActive (false);
			gameover.gameObject.SetActive (true);
			Time.timeScale=0;
			break;

		}

	}


    void OnCollisionEnter(Collision other)
    {


        if (other.gameObject.tag == "Player")
        {   
            Debug.Log("Done");
			health -= 1;
			//InvokeRepeating("SpawnObject", 0, 0);
		Destroy (other.gameObject);


			//Gameplayer.transform.position= new Vector3 (-24, 0.5f, 0);

			  
		}



    }



 


	void GameplayerPosition()

	{




	}










}




// Use this for initialization
