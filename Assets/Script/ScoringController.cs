using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoringController : MonoBehaviour {
	public GameObject Gameplayer;
	public Text Scoretext;

	// Use this for initialization
	public int Score;
	void Start () {
		Score = 0;

		scoreShow (); 

	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter(Collider other)
	{	 




		if (other.gameObject.tag == "Player")
			Score = Score + 1;
		Debug.Log(Score);
		scoreShow ();

		//InvokeRepeating("SpawnObject", 0, 0);

		positioning ();




	}

	void scoreShow()
	{
		Scoretext.text = "Score: " + Score.ToString ();
	}

	void positioning()
	{
		Gameplayer.transform.position= new Vector3 (-24, 1, 0);
	}





}
