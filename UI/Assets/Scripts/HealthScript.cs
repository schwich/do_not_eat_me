using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

	public int hp = 10;
	public bool	eatebale = false;

	public void Eat(){
		if (hp == 0)
			Destroy (gameObject);
		else 
			hp = hp - 1;
	}

	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log(coll.gameObject.name + " eating " + gameObject.name);
		eatebale = true;
		InvokeRepeating("Eat", 1, 1);
	}

//	void Update () {
//		if (eatebale == true) {
//			Eat(1);
//		}
//
//	}
}
