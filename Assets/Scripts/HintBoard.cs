using UnityEngine;
using System.Collections;

public class HintBoard : MonoBehaviour
{
	// the menu button sprite
	public Texture LionHerbivore;
	public Texture LionPlant;

	public Texture DwarfSandSnakeHerbivore;
	public Texture DwarfSandSnakePlant;

	public Texture LeopardHerbivore;
	public Texture LeopardPlant;

	public Texture AfricanWildDogHerbivore;
	public Texture AfricanWildDogPlant;

	public Texture ServalCatHerbivore;
	public Texture ServalCatPlant;

	public Texture Arrow;

	public Texture Empty;

	private Texture leftSquare;
	private Texture rightSquare;

	// Use this for initialization
	void Start ()
	{
		leftSquare = Empty;
		rightSquare = Empty;
	}

	void OnGUI() {
		
		// draw the plant menu
		GUILayout.BeginArea (new Rect (400, 500, 600, 550));
		GUILayout.BeginHorizontal ("box");

		GUI.enabled = false;
		GUILayout.Button (new GUIContent (leftSquare));
		GUILayout.Button (new GUIContent (Arrow));
		GUILayout.Button (new GUIContent (rightSquare));
		
		// End GUI for plant menu
		GUILayout.EndVertical();
		GUILayout.EndArea ();
		

	}

	public void setNextPredator(int nextPredator) {

		switch (nextPredator)
		{
		case 1:
			//Lion
			leftSquare = LionHerbivore;
			rightSquare = LionPlant;
			break;
		case 2:
			//DwarfSandSnake
			leftSquare = DwarfSandSnakeHerbivore;
			rightSquare = DwarfSandSnakePlant;		
			break;
		case 3:
			//Leopard
			leftSquare = LeopardHerbivore;
			rightSquare = LeopardPlant;		
			break;
		case 4:
			//AfricanWildDog
			leftSquare = AfricanWildDogHerbivore;
			rightSquare = AfricanWildDogPlant;
			break;
		case 5:
			//ServalCat
			leftSquare = ServalCatHerbivore;
			rightSquare = ServalCatPlant;
			break;
		default:
			//Lion
			leftSquare = LionHerbivore;
			rightSquare = LionPlant;			
			break;
		}

	}

	// Update is called once per frame
	void Update ()
	{
	
	}
}

