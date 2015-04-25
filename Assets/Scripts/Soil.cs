﻿using UnityEngine;
using System.Collections;

public class Soil : MonoBehaviour {

	// hold a reference to the game object placed on top of soil
	public GameObject currentlyPlacedPiece = null;
	
	void OnMouseUpAsButton() {
		// Is there something to build?
		if (BuildMenu.currentlyBuilding != null) {

			// is it a plant? you can only build plants on the soil
			if (BuildMenu.currentlyBuilding.gameObject.tag != "Plant") return;

			// Build it and hold a reference to the newly created game piece
			currentlyPlacedPiece = (GameObject) Instantiate(BuildMenu.currentlyBuilding.gameObject, transform.position, Quaternion.identity);
			BuildMenu.currentResources -= BuildMenu.currentlyBuilding.price;
			// Add the price of the game piece onto the score
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

	// highlight the soil with green when the player mouses over it
	void OnMouseOver () {
		renderer.material.color = Color.green;	
	}
	
	void OnMouseExit() {
		renderer.material.color = Color.white;
	}
}
