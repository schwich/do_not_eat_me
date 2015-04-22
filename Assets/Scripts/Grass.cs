using UnityEngine;
using System.Collections;

public class Grass : MonoBehaviour {

	bool tileSelected = false;


	void OnMouseUpAsButton() {
		// Is there something to build?
		if (BuildMenu.currentlyBuilding != null) {
			// Build it
			Instantiate(BuildMenu.currentlyBuilding.gameObject, transform.position, Quaternion.identity);
			BuildMenu.currentResources -= BuildMenu.currentlyBuilding.price;
			BuildMenu.score += BuildMenu.currentlyBuilding.price;
			BuildMenu.currentlyBuilding = null;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseOver () {
		if(Input.GetMouseButtonDown(0)) {
			tileSelected = true;
			Debug.Log(transform.position);
		}
		
		
		GetComponent<Renderer>().material.color = Color.yellow;
		
	}
	
	void OnMouseExit() {
		if(!tileSelected) {
			//White resets to original color
			GetComponent<Renderer>().material.color = Color.white;
		}
	}
}
