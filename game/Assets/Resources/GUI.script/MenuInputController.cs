using UnityEngine;
using System.Collections;

public class MenuInputController : MonoBehaviour {

	private float negativeQuarterLevelHeight = -(Constants.levelHeight / 4);
	private float halfLevelWidth = (Constants.levelWidth / 2);
	private int buttonsAmount = 2;
	private GameObject[] buttons;
	private Button button;
	private Vector3 nextButtonPos;
	private int selectedButton = 0;
	private bool playingGame = false;

	void Start () {
		
		buttons = new GameObject[buttonsAmount];
		nextButtonPos = new Vector3(halfLevelWidth, negativeQuarterLevelHeight, 0);
		AddButtons();
		SetSelectedButton(0);
	}

	void Update () {

		InputCheck();
	}

	void ActivateSelectedButton() {

		buttons[selectedButton].GetComponent<Button>().Pushed();
	}

	void SetSelectedButton(int correctButton) {

		if(selectedButton + correctButton <= buttons.Length - 1 && selectedButton + correctButton >= 0){

			buttons[selectedButton].GetComponent<Button>().DeSelect();
			selectedButton += correctButton;
			buttons[selectedButton].GetComponent<Button>().Select();
		}
	}

	void AddButtons() {

		nextButtonPos += new Vector3(0, negativeQuarterLevelHeight, 0);
		GameObject newStartButton = Instantiate(Resources.Load("GUI.prefabs/ButtonController"), nextButtonPos, Quaternion.identity) as GameObject;
		newStartButton.transform.name = "StartButton";
		newStartButton.transform.parent = transform.GetChild(0);
		buttons[0] = newStartButton;


		nextButtonPos += new Vector3(0, negativeQuarterLevelHeight, 0);
		GameObject newGameModeButton = Instantiate(Resources.Load("GUI.prefabs/ButtonController"), nextButtonPos, Quaternion.identity) as GameObject;
		newGameModeButton.transform.name = "GameModeButton";
		newGameModeButton.transform.parent = transform.GetChild(0);
		buttons[1] = newGameModeButton;
	}
	
	void InputCheck() {

		if(!playingGame){

			if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) {

				SetSelectedButton(1);
			} else if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) {
				
				SetSelectedButton(-1);
			} else if(Input.GetKeyDown(KeyCode.Space)) {
				
				ActivateSelectedButton();	
			}
		}
	}

	public void ChangeMenuButtonState(){

		if(playingGame){

			playingGame = false;
		} else {

			playingGame = true;
		}
	}
}
