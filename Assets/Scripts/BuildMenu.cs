﻿using UnityEngine;
using System.Collections;

public class BuildMenu : MonoBehaviour {

	// Currently building...
	public static BuildInfo currentlyBuilding;

	// Currently about to delete?
	public static bool currentlyDeleting = false;

	// Player's current resource amount
	public static int currentResources = 100;

	// Plant prefabs
	public BuildInfo[] plants;

	// Prey prefabs
	public BuildInfo[] prey;

	void OnGUI() {

		// draw resource menu
		GUILayout.BeginArea (new Rect (10, 10, 50, 50));
		GUILayout.BeginHorizontal ("box");

		// draw resource counter
		GUILayout.Button (new GUIContent (currentResources.ToString ()));

		// end GUI for resource menu
		GUILayout.EndHorizontal ();
		GUILayout.EndArea ();

		// draw the plant menu
		GUILayout.BeginArea (new Rect (20, 100, 50, 300));
		GUILayout.BeginVertical ("box");

		// Draw each plant's build info
		foreach (BuildInfo info in plants) {
			GUI.enabled = currentResources >= info.price;
			// if button is clicked, then set currentlyBuilding to the info of the button you clicked
			if (GUILayout.Button(new GUIContent(info.price.ToString(), info.previewImage))) currentlyBuilding = info;
		}

		// End GUI for plant menu
		GUILayout.EndVertical();
		GUILayout.EndArea ();

		// Now, draw prey menu
		GUILayout.BeginArea (new Rect (200, 10, 300, 100));
		GUILayout.BeginHorizontal ("box");

		// draw each prey's build info
		foreach (BuildInfo info in prey) {
			GUI.enabled = currentResources >= info.price;
			if (GUILayout.Button(new GUIContent(info.price.ToString(), info.previewImage))) currentlyBuilding = info;
		}

		// End GUI for prey menu
		GUILayout.EndVertical();
		GUILayout.EndArea();
	}

	// this method increases score every 2s
	void increaseResources() {
		currentResources += 50;
	}

	// Use this for initialization
	void Start () {
		// set resources to grow over time
		InvokeRepeating ("increaseResources", 2, 3.0F);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
