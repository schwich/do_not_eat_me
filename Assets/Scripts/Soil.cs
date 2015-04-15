using UnityEngine;
using System.Collections;

public class Soil : MonoBehaviour {

	void OnMouseUpAsButton() {
		// Is there something to build?
		if (BuildMenu.currentlyBuilding != null) {
			// Build it
			Instantiate(BuildMenu.currentlyBuilding.gameObject, transform.position, Quaternion.identity);
			BuildMenu.currentResources -= BuildMenu.currentlyBuilding.price;
			BuildMenu.currentlyBuilding = null;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
