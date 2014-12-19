using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
	private Sprite normal;
	private Sprite selected;
	private string buttonName;
	private int whatLevel;

	private AxeTrowing axeTrow;
	private SpriteRenderer buttonSprite;
	private MenuInputController menuControllerScript;
	private GameOverInputController gameOverControllerScript;
	private TileSystem tileSystem;
	private PortalCheck portal;
	
	void Start(){

		whatLevel = 1;
		buttonSprite = gameObject.GetComponent<SpriteRenderer>();
		
		GetMenuControllerScript();
		GetGameOverButtonScript();

		GetSprites();
	}

	public void GetSprites(){

		buttonName = this.transform.name;
		switch(buttonName){
			
		case "StartButton":

			normal = Resources.Load<Sprite>("GUI.art/StartNormal");
			selected = Resources.Load<Sprite>("GUI.art/StartSelected");
			Select();
			break;
		case "GameModeButton":
			
			ChangeLevelButtonArt();
			DeSelect();
			break;
		case "RestartButton":

			normal = Resources.Load<Sprite>("GUI.art/RestartNormal");
			selected = Resources.Load<Sprite>("GUI.art/RestartSelected");
			Select();
			break;
		case "MenuButton":
			
			normal = Resources.Load<Sprite>("GUI.art/MenuButtonNormal");
			selected = Resources.Load<Sprite>("GUI.art/MenuButtonSelected");
			DeSelect();
			break;
		}

	}
	public void DeSelect(){
		
		buttonSprite = gameObject.GetComponent<SpriteRenderer>();
		buttonSprite.sprite = normal;
	}
	public void Select(){
		
		buttonSprite = gameObject.GetComponent<SpriteRenderer>();
		buttonSprite.sprite = selected;
		
	}
	public void Pushed(){

		switch (buttonName){

		case "StartButton":

			ChangeMenuState();
			ChangeGameAttributesState(true);
			ChangeMenuAttributesState(false);
			ActivateLevel(whatLevel);

			break;
		case "GameModeButton":

			ChangeLevel();
			ChangeLevelButtonArt();

			break;
		case "RestartButton":

			RestartGUI();
			ChangeGameOverAttributessState(false);
			ChangeGameOverButtonsState(false);
			ChangeGameAttributesState(true);
			ChangePlayingGameState();
			
			break;
		case "MenuButton":

			Application.LoadLevel(0);
			break;
		}
	}

	void RestartGUI(){

		GameObject gameGui = GameObject.FindGameObjectWithTag("GameGUI");
		ChangeInGameGUI GUIScript = gameGui.GetComponent<ChangeInGameGUI>();
		GUIScript.RestartTimer();
	}

	void RemoveLevel(){
		
		GameObject tileHolder = GameObject.FindGameObjectWithTag("TilesHolder");
		tileSystem = tileHolder.GetComponent<TileSystem>();
		tileSystem.RemoveLevel();
	}

	void ChangeLevelButtonArt(){

		if(whatLevel == 1){
			
			normal = Resources.Load<Sprite>("GUI.art/lvl1Normal");
			selected = Resources.Load<Sprite>("GUI.art/lvl1Selected");
		} else if(whatLevel == 2){
			
			normal = Resources.Load<Sprite>("GUI.art/lvl2Normal");
			selected = Resources.Load<Sprite>("GUI.art/lvl2Selected");
		} else if(whatLevel == 3){
			
			normal = Resources.Load<Sprite>("GUI.art/lvl3Normal");
			selected = Resources.Load<Sprite>("GUI.art/lvl3Selected");
		}
		Select();
	}

	void ChangeLevel(){

		if(whatLevel == 3){
			
			whatLevel = 1;
		}else{

			whatLevel += 1;
		}
		GameObject tileHolder = GameObject.FindGameObjectWithTag("TilesHolder");
		tileSystem = tileHolder.GetComponent<TileSystem>();
		tileSystem.ChangeLevel(whatLevel);
	}

	void GetAxeTrowingScript(){
		
		GameObject axeTrowing = GameObject.FindGameObjectWithTag("AxesHolder");
		axeTrow = axeTrowing.GetComponent<AxeTrowing>();
	}
	
	void ChangePlayingGameState(){
		
		GetAxeTrowingScript();
		axeTrow.ChangePlayingGameState(true);
		
	}

	void GetGameOverButtonScript(){
		
		GameObject gameoverController = GameObject.FindGameObjectWithTag("GameOverGUI");
		gameOverControllerScript = gameoverController.GetComponent<GameOverInputController>();
	}

	void ChangeGameOverButtonsState(bool setActive){
		
		gameOverControllerScript.ChangeGameOverMenuState(setActive);
	}

	void GetMenuControllerScript(){

		GameObject menuController = GameObject.FindGameObjectWithTag("MenuAttributes");
		menuControllerScript = menuController.GetComponent<MenuInputController>();
	}
	
	void ChangeMenuState(){

		menuControllerScript.ChangeMenuButtonState();
	}

	void ActivateLevel(int level){

		GameObject tileHolder = GameObject.FindGameObjectWithTag("TilesHolder");
		tileSystem = tileHolder.GetComponent<TileSystem>();
		tileSystem.ChooseLevelCreation();
	}

	void ChangeGameOverAttributessState(bool setActive){
		
		GameObject gameOver = GameObject.FindGameObjectWithTag("GameOverGUI");
		foreach(Transform go in gameOver.transform){

			if(setActive){

				go.gameObject.SetActive(true);
			}else{

				go.gameObject.SetActive(false);
			}
		}
	}

	void ChangeGameAttributesState(bool setActive){

		GameObject gameAttr = GameObject.FindGameObjectWithTag("GameAttributes");
		foreach(Transform go in gameAttr.transform){

			if(setActive){

				go.gameObject.SetActive(true);
			}else{

				go.gameObject.SetActive(false);
			}
		}
	}
	
	void ChangeMenuAttributesState(bool setActive){
		
		GameObject menuAttr = GameObject.FindGameObjectWithTag("MenuAttributes");
		foreach(Transform go in menuAttr.transform){

			if(setActive){

				go.gameObject.SetActive(true);
			}else {

				go.gameObject.SetActive(false);
			}
		}
	}
}
