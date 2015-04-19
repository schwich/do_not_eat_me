using UnityEngine;
using System.Collections;

public class GameOverWall : MonoBehaviour
{
	bool GameIsOver = false;

	GUIStyle largeFont;

	void OnCollisionStay2D(Collision2D collision) {
		
		Debug.Log ("Hit gameover wall!");
		GameIsOver = true;
	
	}

	void Start () 
	{

		largeFont = new GUIStyle();
	
		largeFont.fontSize = 32;
		largeFont.normal.textColor = Color.red;

	}

	void OnGUI() {

		if (GameIsOver) {
			// draw resource menu
			GUILayout.BeginArea (new Rect (350, 350, 600, 600));
			GUILayout.BeginHorizontal ("box");
		
			GUILayout.Label("You Lost!", largeFont);
		
			// end GUI for resource menu
			GUILayout.EndHorizontal ();
			GUILayout.EndArea ();
		
		}
	}

}

