using UnityEngine;
using System.Collections;

public class AxeTrowing : MonoBehaviour {

	private int remainingAxesPlayerOne = Constants.maxAxes;
	private int remainingAxesPlayerTwo = Constants.maxAxes;
	private Transform playerOneTransform;
	private Transform playerTwoTransform;
	private bool playerOneDied = false;
	private bool playerTwoDied = false;
	private bool playingGame = true;

	void Update(){

		HandleInput();
	}

	private void HandleInput() {

		if(playingGame){

			if(Input.GetKeyDown(KeyCode.Space) && !playerOneDied){

				if(remainingAxesPlayerOne != 0){

					GameObject player = GameObject.Find ("PlayerOne");
					playerOneTransform = player.transform;

					remainingAxesPlayerOne --;
					GameObject newAxe = Instantiate(Resources.Load("axe.prefab/axePlayerOne"), playerOneTransform.position,transform.rotation) as GameObject;
					newAxe.name = "AxePlayerOne";
					newAxe.transform.parent = transform;
				}
			}

			if(Input.GetKeyDown(KeyCode.KeypadEnter) && !playerTwoDied){
				
				if(remainingAxesPlayerTwo != 0){
					
					GameObject player = GameObject.Find ("PlayerTwo");
					playerTwoTransform = player.transform;

					remainingAxesPlayerTwo --;
					GameObject newAxe = Instantiate(Resources.Load("axe.prefab/axePlayerTwo"), playerTwoTransform.position,transform.rotation) as GameObject;
					newAxe.name = "AxePlayerTwo";
					newAxe.transform.parent = transform;
				}
			}
		}
	}

	public void ReturnAxePlayerOne(){
		
		remainingAxesPlayerOne ++;
	}

	public void ReturnAxePlayerTwo(){
		
		remainingAxesPlayerTwo ++;
	}

	public void APlayerDied(int deathPlayer){

		if(deathPlayer == 1){

			playerOneDied = true;
		}else {

			playerTwoDied = true;
		}
	}

	public void APlayerIsRevived(int revivedPlayer){
		
		if(revivedPlayer == 1){
			
			playerOneDied = false;
		}else {
			
			playerTwoDied = false;
		}
	}

	public void ChangePlayingGameState(bool setActive){

		if(setActive){

			playingGame = true;
		} else {

			playingGame = false;
		}
	}

	public int GetRemainingAxesP1(){

		return remainingAxesPlayerOne;
	}

	public int GetRemainingAxesP2(){

		return remainingAxesPlayerTwo;
	}


}