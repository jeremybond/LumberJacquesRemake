using UnityEngine;
using System.Collections;

public class AxeControllerPlayerOne : MonoBehaviour {

	private float axeVelocityY = 1.4f;
	private float axeVelocityX = 5;

	public bool axeHasLanded;
	private float raycastLenght = 0.35f;

	private AxeTrowing axeTrowing;
	private characterOneController characterContr;
	private PlayerReviveScript playerRevive;
	public bool playerWalkingDirectionIsLeft = false;

	void Start(){
		
		GetParent();
		GetPlayerControllers();
		
		if(playerWalkingDirectionIsLeft){
			
			transform.position += new Vector3(-0.3f, 0.2f, 0);
		}else{
			
			transform.position += new Vector3(0.3f, 0.2f, 0);
		}
		
	}
	
	void GetPlayerControllers(){
		
		
		GameObject player = GameObject.Find("PlayerOne");
		characterContr = player.GetComponent<characterOneController>();
		playerWalkingDirectionIsLeft = characterContr.characterWalkDirectionIsLeft;
	}
	
	void GetParent(){
		
		GameObject axeHolder = GameObject.FindGameObjectWithTag("AxesHolder");
		axeTrowing = axeHolder.GetComponent<AxeTrowing>();
	}

	void Update(){

		if(axeHasLanded){
			
			CheckCollision();
		}else{

			RotateAxe();
			AddGravity();
			CheckCollision();
			CheckCharacterDirection();

			MoveAxe();
		}
	}
	void MoveAxe(){
		
		transform.position += new Vector3(axeVelocityX * Time.deltaTime, axeVelocityY * Time.deltaTime, 0);
	}
	void CheckCharacterDirection(){

		if(playerWalkingDirectionIsLeft){
			
			axeVelocityX = -Constants.axeTrownSpeed;
		} else{
			
			axeVelocityX = Constants.axeTrownSpeed;
		}
	}
	void RotateAxe(){

		transform.Rotate(0, 0, 10f);
	}
	void AddGravity(){
		
		if(axeVelocityY >= -3){
			
			axeVelocityY -= 0.1f;
		}
	}
	private Vector2 GetOriginOffset(float offSetX, float offSetY) {
		
		Vector2 originPos = transform.position;
		originPos.x -= offSetX;
		originPos.y -= offSetY;
		
		return originPos;
	}

	private void CheckCollision() {
		
		Vector2 horizontalDirection = Vector2.right / 5f;
		Vector2 verticalDirection = Vector2.up / 5f;
		
		Vector2 originDown = GetOriginOffset(0.0875f, 0.125f);
		Vector2 originUp = GetOriginOffset(0.0875f,-0.125f);
		Vector2 originLeft = GetOriginOffset(0.125f, 0.0875f);
		Vector2 originRight = GetOriginOffset(-0.125f, 0.0875f);
		
		//DOWN
		RaycastHit2D hitDown = Physics2D.Raycast(originDown, horizontalDirection, raycastLenght);
		if(hitDown.collider != null){//there is something under me
			
			StandardHitChecks(hitDown);
			if(!axeHasLanded && hitDown.collider.tag != "PlayerOne" && hitDown.collider.tag != "PlayerTwo"){

				HitSomething(transform.position.x, (hitDown.collider.transform.position.y + Constants.axeTileDelta));
			}
		}
		//UP
		RaycastHit2D hitUp = Physics2D.Raycast(originUp, horizontalDirection, raycastLenght);
		if(hitUp.collider != null){//there is something above me
			
			StandardHitChecks(hitUp);
			if(!axeHasLanded && hitUp.collider.tag != "PlayerOne" && hitUp.collider.tag != "PlayerTwo"){
				
				HitSomething(transform.position.x, (hitUp.collider.transform.position.y - Constants.axeTileDelta));
			}
		}
		//LEFT
		RaycastHit2D hitLeft = Physics2D.Raycast(originLeft, verticalDirection, raycastLenght);
		if(hitLeft.transform != null){//there is something on my left side
			
			StandardHitChecks(hitLeft);
			if(!axeHasLanded && hitLeft.collider.tag != "PlayerOne" && hitLeft.collider.tag != "PlayerTwo"){

				HitSomething((hitLeft.collider.transform.position.x + Constants.axeTileDelta),transform.position.y);
			}
		}
		//RIGHT
		RaycastHit2D hitRight = Physics2D.Raycast(originRight, verticalDirection, raycastLenght);
		if(hitRight.collider != null){//there is something on my right side

			StandardHitChecks(hitRight);
			if(!axeHasLanded && hitRight.collider.tag != "PlayerOne" && hitRight.collider.tag != "PlayerTwo"){
				
				HitSomething((hitRight.collider.transform.position.x - Constants.axeTileDelta),transform.position.y);
			}
		}
	}

	void StandardHitChecks(RaycastHit2D hit){

		if(!axeHasLanded && hit.collider.tag == "PlayerTwo"){

			Destroy(hit.collider.gameObject);
			DeactivatePlayerOneAttack();
			StartReviveTimer();
		}
		if(axeHasLanded && hit.collider.tag == "PlayerOne"){
			
			RemoveSelf();
			axeHasLanded = false;
		}
	}

	void StartReviveTimer(){

		GameObject playerReviveTimer = GameObject.FindGameObjectWithTag("GameAttributes");
		playerRevive = playerReviveTimer.GetComponent<PlayerReviveScript>();
		playerRevive.APlayerDied(2);
	}

	void DeactivatePlayerOneAttack(){

		axeTrowing.APlayerDied(2);
	}

	void HitSomething(float x, float y){

		axeHasLanded = true;
		transform.position = new Vector3(x, y, 0);
	}


	void RemoveSelf(){
		
		Destroy(gameObject);
		axeTrowing.ReturnAxePlayerOne();
	}

}