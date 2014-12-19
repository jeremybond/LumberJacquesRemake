using UnityEngine;
using System.Collections;

public class GameOverInputController : MonoBehaviour {
	
	private float negativeQuarterLevelHeight = -(Constants.levelHeight / 4);
	private float aTirthLevelWidth = (Constants.levelWidth / 3);
	private int buttonsAmount = 2;
	private GameObject[] buttons;
	private Button button;
	private Vector3 nextButtonPos;
	private int selectedButton = 0;
	private bool gameOver = false;
	private bool playerOneWins;

	private GameObject winScreen;
	private SpriteRenderer winScreenRenderer;

	void Start () {
		
		buttons = new GameObject[buttonsAmount];
		nextButtonPos = new Vector3(0, negativeQuarterLevelHeight * 3, 0);
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
		
		nextButtonPos += new Vector3(aTirthLevelWidth, 0, 0);
		GameObject newRestartButton = Instantiate(Resources.Load("GUI.prefabs/ButtonController"), nextButtonPos, Quaternion.identity) as GameObject;
		newRestartButton.transform.name = "RestartButton";
		newRestartButton.transform.parent = transform.GetChild(0);
		buttons[0] = newRestartButton;
		
		
		nextButtonPos += new Vector3(aTirthLevelWidth, 0, 0);
		GameObject newMenuButton = Instantiate(Resources.Load("GUI.prefabs/ButtonController"), nextButtonPos, Quaternion.identity) as GameObject;
		newMenuButton.transform.name = "MenuButton";
		newMenuButton.transform.parent = transform.GetChild(0);
		buttons[1] = newMenuButton;


		
		GameObject newWinsScreen = Instantiate(Resources.Load("GUI.prefabs/winScreen"), new Vector3(Constants.levelWidth / 2, negativeQuarterLevelHeight, 0), Quaternion.identity) as GameObject;
		newWinsScreen.transform.name = "WinsScreen";
		newWinsScreen.transform.parent = transform.GetChild(0);
		winScreenRenderer = newWinsScreen.GetComponent<SpriteRenderer>();

	}


	public void ChangeWinningPlayer(bool playerOneHasWon){
		
		//GetSpriteRenderer();
		if(playerOneHasWon){
			
			winScreenRenderer.sprite = Resources.Load<Sprite>("GUI.art/PlayerOneWinsScreen");
		} else {
			
			winScreenRenderer.sprite = Resources.Load<Sprite>("GUI.art/PlayerTwoWinsScreen");
		}
	}
	
	void InputCheck() {
		
		if(gameOver){

			if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) {
				
				SetSelectedButton(1);
			} else if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) {
				
				SetSelectedButton(-1);
			} else if(Input.GetKeyDown(KeyCode.Space)) {
				
				ActivateSelectedButton();	
			}
		}
	}

	public void ChangeGameOverMenuState(bool setActive){

		if(setActive){

			gameOver = true;
		} else {

			gameOver = false;
		}
	}
}
