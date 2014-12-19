using UnityEngine;
using System.Collections;

public class RespawnPoints : MonoBehaviour {
	
	public Vector3[] allSpawnPointsLevelOne;
	public Vector3[] allSpawnPointsLevelTwo;
	public Vector3[] allSpawnPointsLevelThree;

	void Start(){

		// 	LEVEL 1 SPAWN POINTS
		allSpawnPointsLevelOne = new Vector3[10];
		allSpawnPointsLevelOne[1] = new Vector3(1.1f, -1.4f, 0);
		allSpawnPointsLevelOne[2] = new Vector3(6.9f, -3f, 0);
		allSpawnPointsLevelOne[3] = new Vector3(8.3f, -0.6f, 0);
		allSpawnPointsLevelOne[4] = new Vector3(10.5f, -3f, 0);
		allSpawnPointsLevelOne[5] = new Vector3(11.7f, -6.2f, 0);
		allSpawnPointsLevelOne[6] = new Vector3(8.7f, -4.9f, 0);
		allSpawnPointsLevelOne[7] = new Vector3(3.9f, -6.2f, 0);
		allSpawnPointsLevelOne[8] = new Vector3(2.3f, -5, 0);
		allSpawnPointsLevelOne[9] = new Vector3(2.7f, -2.9f, 0);
		allSpawnPointsLevelOne[0] = new Vector3(4.7f, -4.9f, 0);

		// 	LEVEL 2 SPAWN POINTS
		allSpawnPointsLevelTwo = new Vector3[10];
		allSpawnPointsLevelTwo[1] = new Vector3(10.5f, -5, 0);
		allSpawnPointsLevelTwo[2] = new Vector3(2.9f, -6.2f, 0);
		allSpawnPointsLevelTwo[3] = new Vector3(2.5f, -3.4f, 0);
		allSpawnPointsLevelTwo[4] = new Vector3(2.9f, -1, 0);
		allSpawnPointsLevelTwo[5] = new Vector3(10.2f, -3.2f, 0);
		allSpawnPointsLevelTwo[6] = new Vector3(11.7f, -1.2f, 0);
		allSpawnPointsLevelTwo[7] = new Vector3(5.5f, -1.8f, 0);
		allSpawnPointsLevelTwo[8] = new Vector3(7.7f, -1.8f, 0);
		allSpawnPointsLevelTwo[9] = new Vector3(5.5f, -4.2f, 0);
		allSpawnPointsLevelTwo[0] = new Vector3(7.7f, -4.2f, 0);
		
		//	LEVEL 3 SPAWN POINTS
		allSpawnPointsLevelThree = new Vector3[10];
		allSpawnPointsLevelThree[1] = new Vector3(12.1f, -6.2f, 0);
		allSpawnPointsLevelThree[2] = new Vector3(7.9f, -5.2f, 0);
		allSpawnPointsLevelThree[3] = new Vector3(7.9f, -1.4f, 0);
		allSpawnPointsLevelThree[4] = new Vector3(10.3f, -4.2f, 0);
		allSpawnPointsLevelThree[5] = new Vector3(10.9f, -1f, 0);
		allSpawnPointsLevelThree[6] = new Vector3(6.1f, -3.8f, 0);
		allSpawnPointsLevelThree[7] = new Vector3(1.7f, -4.4f, 0);
		allSpawnPointsLevelThree[8] = new Vector3(4.5f, -6.2f, 0);
		allSpawnPointsLevelThree[9] = new Vector3(4.7f, -1.2f, 0);
		allSpawnPointsLevelThree[0] = new Vector3(2.5f, -0.7f, 0);


	}
	public Vector3 GetRandomPos(int level){

		Vector3 newSpawnPoint = new Vector3(0, 0, 0);
		if(level == 1){
			
			newSpawnPoint = allSpawnPointsLevelOne[Random.Range(0, 9)];
		} else if(level == 2){
			
			newSpawnPoint = allSpawnPointsLevelTwo[Random.Range(0, 9)];
		} else if( level == 3){
			
			newSpawnPoint = allSpawnPointsLevelThree[Random.Range(0, 9)];
		}
		return newSpawnPoint;
	}
}
