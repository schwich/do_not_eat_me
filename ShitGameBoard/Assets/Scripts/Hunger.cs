using UnityEngine;
using System.Collections;

public class Hunger : MonoBehaviour {

	// last attack time
	float last = 0;





	[SerializeField]
	// the value when the predator is full
	int fullHungerValue = 100;
	// the current value of the predator's hungry meter
	int hunger = 0;
	// the value that the predator eats each time they eat a prey
	int amountToEatPerTick = 20;

	public void Eat() {

	}

	void OnCollisionStay2D(Collision2D collision) {

		// Collided with a plant?
		if (collision.gameObject.tag == "Plant") {
			// Eat once a second
			if (Time.time - last >= 1) {

				Debug.Log ("Does it eat?");

				collision.gameObject.GetComponent<Health>().lowerHealth(amountToEatPerTick);
				hunger += amountToEatPerTick;
				last = Time.time;

				if (hunger >= fullHungerValue) {
					Destroy(gameObject);
					Debug.Log ("Kill lion");
				}
			}
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
