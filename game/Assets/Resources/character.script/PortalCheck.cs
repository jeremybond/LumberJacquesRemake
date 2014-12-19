using UnityEngine;
using System.Collections;

public class PortalCheck : MonoBehaviour {

	private int whatLevel;

	void Start(){

		whatLevel = TileSystem.whatLevel;
	}

	void Update () {

		CheckLevelForPortalCheck(whatLevel);
	}

	void CheckLevelForPortalCheck(int level){

		if(whatLevel == 1){

			EnterPortalCheckLevelOne();
		} else if(whatLevel == 2){

			EnterPortalCheckLevelTwo();
		} else if(whatLevel == 3){

			EnterPortalCheckLevelThree();
		}
	}

	//	LEVEL ONE
	void EnterPortalCheckLevelOne(){

		if(transform.position.x <= 0){
			
			HorizontalPortalLevelOne(true);
		} else if(transform.position.x >= Constants.levelWidth) {  
			
			HorizontalPortalLevelOne(false);
		} 
		if(transform.position.y <= (-Constants.levelHeight-Constants.tileSize)) {
			
			VerticalPortalLevelOne(true);
		} else if(transform.position.y >= 0) {

			VerticalPortalLevelOne(false);
		}
	}

	void HorizontalPortalLevelOne(bool fromLeftSide){
		
		float xTransition = Constants.levelWidth + Constants.playerTileDelta;
		float yTransition = 4;
		if(fromLeftSide){

			yTransition = -yTransition;
		}else{

			xTransition = -xTransition;
		}
		Transport(xTransition, yTransition);
	}

	void VerticalPortalLevelOne(bool fromBottomSide){
		
		float xTransition = 0.6f;
		float yTransition = Constants.levelHeight;
		if(!fromBottomSide){
			
			xTransition = -xTransition;
			yTransition = -yTransition;
		}
		Transport(xTransition, yTransition);
	}

	// 	LEVEL TWO
	void EnterPortalCheckLevelTwo(){

		bool leftSide = false; 
		bool lowerPortal = false;
		bool enterPortal = false;
		if(transform.position.x <= 0){

			leftSide = true;
			enterPortal = true;
		} else if(transform.position.x >= Constants.levelWidth) {  

			leftSide = false;
			enterPortal = true;
		} 
		if(transform.position.y <= -Constants.levelHeight / 2){
			
			lowerPortal = true;
		} else {
			
			lowerPortal = false;
		} 
		if(enterPortal){

			HorizontalPortalLevelTwo(leftSide, lowerPortal);
		}
	}

	void HorizontalPortalLevelTwo(bool fromLeftSide, bool lowerPortal){
		
		float xTransition = Constants.levelWidth;
		float yTransition = -5;
		if(lowerPortal){

			yTransition = -yTransition;
		}
		if(!fromLeftSide){

			xTransition = -xTransition;
		}
		Transport(xTransition, yTransition);
	}

	//	LEVEL TRHEE
	void EnterPortalCheckLevelThree(){
		
		bool leftSide = false; 
		bool bottomPortal = false;
		bool enterPortal = false;
		if(transform.position.y >= 0){
			
			bottomPortal = false;
			enterPortal = true;
		} else if(transform.position.y <= -Constants.levelHeight){  

			bottomPortal = true;
			enterPortal = true;
		} if(transform.position.x <= Constants.levelWidth / 2) {

			leftSide = true;
		} else {
			
			leftSide = false;
		}
		if(enterPortal){
			
			VerticalPortalLevelThree(leftSide, bottomPortal);
		}
	}

	void VerticalPortalLevelThree(bool leftSide, bool bottomPortal){

		float xTransition;
		float yTransition = Constants.levelHeight;
		if(leftSide){

			if(!bottomPortal){
				
				xTransition = 7.8f;
				yTransition = -yTransition;
			}else{

				xTransition = 8.6f;
			}
		}else {

			if(!bottomPortal){
				
				xTransition = -8.6f;
				yTransition = -yTransition;
			} else {

				xTransition = -7.8f;
			}
		}

		Transport(xTransition, yTransition);
	}

	void Transport(float x, float y){
		
		transform.position += new Vector3(x, y, 0);
	}
}
