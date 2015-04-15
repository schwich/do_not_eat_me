using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	// Current Health
	[SerializeField]
	int currentHealth = 100;

	public void lowerHealth(int damage) {
		// Subtract damage from current health
		currentHealth -= damage;

		Debug.Log ("Health now: " + currentHealth);

		// Destroy object if health is depleted to 0
		if (currentHealth <= 0) {
			Destroy(gameObject);
			Debug.Log(gameObject.ToString() + " has been eaten");
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
