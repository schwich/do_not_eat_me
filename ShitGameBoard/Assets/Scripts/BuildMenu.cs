using UnityEngine;
using System.Collections;

public class BuildMenu : MonoBehaviour {

	// Currently building...
	public static BuildInfo currentlyBuilding;

	// Player's current resource amount
	public static int currentResources = 100;

	// Plant prefabs
	public BuildInfo[] plants;

	void OnGUI() {
		GUILayout.BeginArea (new Rect (20, 100, 50, 300));
		GUILayout.BeginVertical ("box");

		// Draw each plant's build info
		foreach (BuildInfo info in plants) {
			Debug.Log (info);
			Debug.Log (plants);
			GUI.enabled = currentResources >= info.price;
			if (GUILayout.Button(new GUIContent(info.price.ToString(), info.previewImage))) currentlyBuilding = info;
			//if (GUILayout.Button(new GUIContent(info.price.ToString(), "grass and herbs"))) currentlyBuilding = info;
		}

		// End GUI
		GUILayout.EndHorizontal ();
		GUILayout.EndArea ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
