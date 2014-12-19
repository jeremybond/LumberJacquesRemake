using UnityEngine;
using System.Collections;

public class ChangeInGameGUI : MonoBehaviour {
	
	private int p1Lives;
	private int p2Lives;
	private int remainingAxesP1 = 5;
	private int remainingAxesP2 = 5;
	private float time = 150;
	private bool playingGame = true;

	private PlayerReviveScript playerReviver;

	void Start () {
		ChangePlayerLifes(5, 5);
	}

	void Update(){
		
		time -= 0.01666f;
		if(time <= 0){

			KillGame();
			playingGame = false;
		} 
		
		if(playingGame){

			ChangeRemainingAxes();
			ChangeGUI();
		}
	}

	void KillGame(){

		GameObject playerReviverObject = GameObject.FindGameObjectWithTag("GameAttributes");
		playerReviver = playerReviverObject.GetComponent<PlayerReviveScript>();
		if(remainingAxesP1 > remainingAxesP2){

			playerReviver.KillAPlayer(2);
		} else {

			playerReviver.KillAPlayer(1);
		}
	}

	void ChangeGUI(){

		guiText.text = ("P1 Lives: " + p1Lives + "      " + "P1 Axes :" + remainingAxesP1 + "        " + (int)time + "         " + "P2 Axes :" + remainingAxesP2 + "      " + "P2 : " + p2Lives);
	}

	public void ChangePlayerLifes(int livesP1, int livesP2){

		p1Lives = livesP1;
		p2Lives = livesP2;
	}

	void ChangeRemainingAxes(){

		GameObject trowAxeObject = GameObject.FindGameObjectWithTag("AxesHolder");
		AxeTrowing axeTrow = trowAxeObject.GetComponent<AxeTrowing>();
		remainingAxesP1 = axeTrow.GetRemainingAxesP1();
		remainingAxesP2 = axeTrow.GetRemainingAxesP2();
	}

	public void RestartTimer(){

		time = 150;
		playingGame = true;
	}
}
