using UnityEngine;
using System.Collections;

public class Predator_Hunger : MonoBehaviour {
	
	// last attack time
	float last = 0;
	
	// the value at which the predator is full
	[SerializeField]
	int fullHungerValue = 100;
	// the current value of the predator's hungry meter
	int hunger = 0;
	// the value that the predator eats each time they eat a prey
	[SerializeField]
	int amountToEatPerTick = 20;
	
	public void Eat() {
		
	}
	
	void OnCollisionStay2D(Collision2D collision) {

		// Collided with a plant!? Game over, buddy
		if (collision.gameObject.tag == "Plant") {
			Debug.Log ("You lost!");
		}
		
		// Collided with a prey? Eat it, yo
		if (collision.gameObject.tag == "Herbivore") {
			// Eat once a second
			if (Time.time - last >= 1) {
				
				collision.gameObject.GetComponent<Health>().lowerHealth(amountToEatPerTick);
				hunger += amountToEatPerTick;
				last = Time.time;
				
				if (hunger >= fullHungerValue) {
					Destroy(gameObject);
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
