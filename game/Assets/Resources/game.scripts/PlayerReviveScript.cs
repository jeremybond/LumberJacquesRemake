using UnityEngine;
using System.Collections;

public class PlayerReviveScript : MonoBehaviour {

	private AxeTrowing axeTrow;
	private GameOverInputController gameOver;

	private bool playerOneHasWon = true;
	private byte lives = 2;

	private byte characterOneLives;
	private byte characterTwoLives;

	void Start(){
		
		characterOneLives = lives;
		characterTwoLives = lives;
	}

	public void APlayerDied(int PlayerId){

		if(PlayerId == 1){

			StartCoroutine(ReviveObject());
		} else {

			StartCoroutine(ReviveSecondObject());
		}
	}

	IEnumerator ReviveObject(){
		
		yield return new WaitForSeconds(1.5f);
		if(!ChangePlayerLives(1)){

			yield return new WaitForSeconds(1.5f);
		}
		Vector3 newPlayerPos = GetNewRandomPos();
		GameObject newPlayerOne = Instantiate(Resources.Load("character.prefabs/PlayerOne"),newPlayerPos, Quaternion.identity) as GameObject;
		newPlayerOne.name = "PlayerOne";
		newPlayerOne.transform.parent = gameObject.transform;
		ChangeGUI();

		if(characterOneLives == 0){

			ChangePlayingGameState();
			newPlayerOne.SetActive(false);
			characterOneLives = lives;
		}
		ActivatePlayerOneAttack();
		yield return null;
	}

	IEnumerator ReviveSecondObject(){
		
		yield return new WaitForSeconds(1f);
		if(!ChangePlayerLives(2)){

			yield return new WaitForSeconds(2f);
		}
		Vector3 newPlayerPos = GetNewRandomPos();
		GameObject newPlayerTwo = Instantiate(Resources.Load("character.prefabs/PlayerTwo"), newPlayerPos, Quaternion.identity) as GameObject;
		newPlayerTwo.name = "PlayerTwo";
		newPlayerTwo.transform.parent = gameObject.transform;
		ChangeGUI();

		if(characterTwoLives == 0){

			ChangePlayingGameState();
			newPlayerTwo.SetActive(false);
			characterTwoLives = lives;
		}
		ActivatePlayerTwoAttack();
		yield return null;
	}

	void ChangeGUI(){

		GameObject gameGUI = GameObject.FindGameObjectWithTag("GameGUI");
		ChangeInGameGUI changeGameGUI = gameGUI.GetComponent<ChangeInGameGUI>();
		changeGameGUI.ChangePlayerLifes(characterOneLives,characterTwoLives);
	}

	void ChangePlayingGameState(){

		GetAxesHolder();
		axeTrow.ChangePlayingGameState(false);

	}

	bool ChangePlayerLives(int playerID){

		if(playerID == 1){

			characterOneLives --;
			if(characterOneLives == 0) {
				
				playerOneHasWon = false;
				EndGame(2);
				return true;
			}
		} else if(playerID == 2){
			
			characterTwoLives --;
			if(characterTwoLives == 0){
				
				playerOneHasWon = true;
				EndGame(1);
				return true;
			}
		}
		return false;
	}
	
	void EndGame(int winningPlayer){

		foreach(Transform go in gameObject.transform){

			if(go.gameObject.tag == "PlayerOne" || go.gameObject.tag == "PlayerTwo"){

				go.gameObject.SetActive(false);
			}
		}
		
		GameObject gameOverObject = GameObject.FindGameObjectWithTag("GameOverGUI");
		gameOver = gameOverObject.GetComponent<GameOverInputController>();
		gameOver.ChangeWinningPlayer(playerOneHasWon);
		gameOver.ChangeGameOverMenuState(true);
		foreach(Transform go in gameOver.transform){
			
			go.gameObject.SetActive(true);
		}
	}

	Vector3 GetNewRandomPos(){

		RespawnPoints respawnPoints = gameObject.GetComponent<RespawnPoints>();
		return respawnPoints.GetRandomPos(TileSystem.whatLevel);
	}
	
	void GetAxesHolder(){
		
		GameObject axeTrowing = GameObject.FindGameObjectWithTag("AxesHolder");
		axeTrow = axeTrowing.GetComponent<AxeTrowing>();
	}

	void ActivatePlayerOneAttack(){

		GetAxesHolder();
		axeTrow.APlayerIsRevived(1);
	}

	void ActivatePlayerTwoAttack(){

		GetAxesHolder();
		axeTrow.APlayerIsRevived(2);
	}

	public void KillAPlayer(int characterID){

		if(characterID == 1){

			characterOneLives = 1;
			ChangePlayerLives(2);
		} else {

			characterTwoLives = 1;
			ChangePlayerLives(1);
		}
		ChangePlayingGameState();
		Debug.Log("kill p" + characterID);
	}

}
