using UnityEngine;
using System.Collections;

public class Grass : MonoBehaviour {

	// hold a reference to the game object placed on top of soil
	public GameObject currentlyPlacedPiece = null;

	void OnMouseUpAsButton() {
		// Is there something to build?
		if (BuildMenu.currentlyBuilding != null) {

			// is it a prey? you can't build plants on the grass
			if (BuildMenu.currentlyBuilding.gameObject.tag != "Herbivore") return;

			// Build it and hold a reference to the newly created gamepiece
			currentlyPlacedPiece = (GameObject) Instantiate(BuildMenu.currentlyBuilding.gameObject, transform.position, Quaternion.identity);
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

	void OnMouseOver () {
		renderer.material.color = Color.yellow;
	}
	
	void OnMouseExit() {
		renderer.material.color = Color.white;
	}
}
