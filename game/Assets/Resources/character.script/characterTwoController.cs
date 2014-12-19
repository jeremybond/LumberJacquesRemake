using UnityEngine;
using System.Collections;

public class characterTwoController : MonoBehaviour {

	private float moveSpeed = 3.5f;
	private float jumpForce = 4.5f;
	private float charVelocityX;
	private float charVelocityY;

	private bool canGoLeft;
	private bool canGoRight;
	public bool grounded;
	
	public bool characterWalkDirectionIsLeft = false;

	private float raycastLenght = 0.4f;

	void Update(){

		AddGravity();
		CheckCollision();
		HandleInput();

		transform.position += new Vector3((charVelocityX * Time.deltaTime), charVelocityY * Time.deltaTime, 0);
	}

	private void AddGravity() {

		if(charVelocityY >= -4f){

			charVelocityY -= 0.14f;
		}
	}

	private void CheckCollision() {

		Vector2 horizontalDirection = new Vector2(raycastLenght, 0);
		Vector2 verticalDirection = new Vector2(0, raycastLenght);
		
		Vector2 originDown = GetOriginOffset(0.2f, 0.25f);
		Vector2 originUp = GetOriginOffset(0.2f,-0.25f);
		Vector2 originLeft = GetOriginOffset(0.25f, 0.2f);
		Vector2 originRight = GetOriginOffset(-0.25f, 0.2f);
		
		//DOWN
		RaycastHit2D hitDown = Physics2D.Raycast(originDown, horizontalDirection, raycastLenght);
		if(hitDown.collider != null){//there is something under me

			if(charVelocityY <= 0){

				transform.position = new Vector3(transform.position.x, (hitDown.collider.transform.position.y + Constants.playerTileDelta), 0);
				charVelocityY = 0;
			}
			grounded = true;
		}
		//UP
		RaycastHit2D hitUp = Physics2D.Raycast(originUp, horizontalDirection, raycastLenght);
		if(hitUp.collider != null){//there is something above me

			if(charVelocityY >= 0){
				
				charVelocityY = 0;
			}
		}
		//LEFT
		RaycastHit2D hitLeft = Physics2D.Raycast(originLeft, verticalDirection, raycastLenght);
		if(hitLeft.collider != null){//there is something left me

			canGoLeft = false;
		} else{
			
			canGoLeft = true;
		}
		//RIGHT
		RaycastHit2D hitRight = Physics2D.Raycast(originRight, verticalDirection, raycastLenght);
		if(hitRight.collider != null){//there is something right me

			canGoRight = false;
		} else {
			
			canGoRight = true;
		}
	}

	private Vector2 GetOriginOffset(float offSetX, float offSetY) {

		Vector2 originPos = transform.position;
		originPos.x -= offSetX;
		originPos.y -= offSetY;

		return originPos;
	}

	private void HandleInput() {

		if(grounded && Input.GetKeyDown(KeyCode.UpArrow)){
			
			charVelocityY += jumpForce;
			transform.position += new Vector3(0, 0.05f, 0);
			grounded = false;
		}
		
		if(Input.GetKey(KeyCode.LeftArrow) && canGoLeft){

			characterWalkDirectionIsLeft = true;
			charVelocityX = -moveSpeed;
		} else if(Input.GetKey(KeyCode.RightArrow) && canGoRight){
			
			characterWalkDirectionIsLeft = false;
			charVelocityX = moveSpeed;
		} else{
			
			charVelocityX = 0;
		}
	}

	public Transform GetTransform(){

		return transform;
	}
}
