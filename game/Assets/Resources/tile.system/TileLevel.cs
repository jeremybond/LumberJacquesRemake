﻿using UnityEngine;
using System.Collections;

public class TileLevel : MonoBehaviour {
	//0:empty
	//1:ground tile grass
	//2:ground tile stone
	//3:background tile tree
	//4:background tile leafs
	//5:background tile stone 
	//6:ground tile stone without collider
	//7:ground tile grass without collider
	public static byte[] levelOne = {

		6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,7,7,7,7,7,7,7,1,0,0,0,0,0,0,1,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,
		6,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,7,
		6,2,5,5,5,5,5,5,5,5,5,5,5,5,0,0,0,0,0,0,0,5,5,5,5,5,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,4,3,0,4,4,4,4,4,4,3,4,4,4,4,4,1,7,
		2,2,5,5,5,5,0,0,0,0,0,0,0,0,0,5,5,5,5,5,5,5,5,5,5,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,4,4,3,3,4,4,4,4,4,0,3,3,4,4,0,4,1,7,
		5,5,5,5,5,0,0,0,0,0,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,4,4,4,3,3,4,4,4,4,4,4,4,4,4,4,4,1,7,
		5,5,5,5,5,0,0,0,0,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,4,4,0,4,4,4,4,4,4,4,4,0,4,4,4,1,7,
		5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,4,4,4,4,4,4,4,0,4,0,4,4,4,4,3,4,1,7,
		5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,7,7,7,1,0,4,4,4,4,4,3,3,3,4,4,4,4,3,3,4,1,7,
		5,5,5,5,5,5,5,5,5,5,5,5,5,5,2,2,2,2,2,2,2,2,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,7,7,1,0,0,4,4,4,4,0,4,3,4,0,4,0,3,0,3,1,7,
		5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,2,6,6,6,6,6,6,7,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,7,1,0,0,0,4,4,4,4,0,4,4,4,4,4,4,4,4,1,7,
		2,2,2,2,2,2,2,2,2,2,2,5,5,5,5,5,2,2,2,2,2,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,7,1,1,1,1,1,1,1,1,4,4,4,4,4,4,4,4,1,7,
		6,6,6,6,6,6,6,6,6,2,5,5,0,5,0,5,5,5,5,5,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,7,7,7,7,7,7,1,4,4,0,4,4,4,3,3,4,1,7,
		6,2,2,2,2,2,2,2,2,5,5,0,0,5,0,0,5,5,5,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,4,4,4,4,4,4,4,4,3,3,1,7,
		6,2,5,5,5,5,5,5,5,5,5,0,0,5,0,0,5,5,5,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,4,4,4,0,4,4,4,3,1,7,
		6,2,5,5,5,5,5,5,5,5,5,0,0,5,0,0,5,5,5,5,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,4,4,1,1,1,1,1,1,7,
		6,2,5,5,5,5,5,5,5,5,5,0,0,0,0,0,5,5,5,0,0,0,0,0,0,0,0,0,1,7,7,7,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,4,4,1,7,7,7,7,7,
		6,2,5,5,5,5,5,5,5,5,5,5,0,0,0,5,5,5,5,0,0,0,0,0,0,0,0,0,1,7,7,7,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,4,4,1,1,1,1,7,
		6,2,5,0,0,0,0,5,5,5,5,5,5,5,5,5,5,5,5,0,0,0,0,0,0,0,0,0,1,7,7,7,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,4,4,4,4,1,7,
		6,2,5,0,5,5,0,0,5,5,2,2,2,2,2,2,2,2,5,5,0,0,0,0,1,1,1,1,1,7,7,7,1,1,1,1,1,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,0,0,0,4,4,4,3,1,7,
		6,2,5,5,5,5,5,0,0,0,5,2,6,6,6,6,2,5,5,5,0,0,0,0,0,1,7,7,7,7,7,7,7,7,7,1,0,0,0,0,0,0,0,0,0,0,1,7,7,7,7,7,7,1,0,0,0,0,3,4,3,3,1,7,
		6,2,5,5,5,5,5,5,5,0,5,5,2,2,2,2,5,5,5,5,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,0,0,0,0,0,3,3,3,3,1,7,
		6,2,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,1,7,
		6,2,2,2,2,2,2,2,2,5,5,5,5,5,5,5,5,5,5,5,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,1,7,
		6,6,6,6,6,6,6,2,0,5,5,5,5,5,5,5,5,5,5,5,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,1,1,
		6,2,2,2,2,2,2,0,0,5,5,5,5,5,5,2,2,2,5,5,5,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,3,3,
		6,2,5,5,5,5,0,0,0,5,5,5,5,5,5,2,6,2,5,5,5,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,3,3,
		6,2,5,5,5,5,5,0,0,5,5,5,5,5,5,2,6,2,5,5,5,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,3,3,
		6,2,5,5,5,5,5,0,5,5,5,5,5,5,5,2,6,2,5,5,5,5,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,3,3,
		6,2,0,0,0,5,5,0,5,2,2,2,2,2,2,2,6,2,2,2,2,2,2,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,3,3,3,3,3,3,
		6,2,0,0,0,0,5,0,5,5,2,6,6,6,6,6,6,6,6,6,6,6,6,6,7,7,7,7,7,1,0,0,0,0,0,0,0,0,0,0,0,0,1,7,7,7,7,7,7,7,7,7,7,7,7,1,0,0,3,3,3,3,3,3,
		6,2,0,0,0,0,5,0,5,5,5,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,3,3,3,3,1,1,
		6,2,0,0,0,0,5,5,5,5,5,5,5,5,5,5,0,0,5,5,5,5,5,5,5,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,1,7,
		6,2,0,0,0,0,5,5,5,5,5,5,5,5,5,5,5,0,0,0,0,0,0,5,5,5,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,1,7,
		6,2,0,0,0,0,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,0,5,5,5,5,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,1,7,
		6,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,1,1,1,1,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,7,
		6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,7,7,7,1,0,0,0,0,0,0,1,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7

	};
	public static byte[] levelTwo = {

		
		7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,
		7,7,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,7,7,
		1,1,3,3,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,3,4,3,3,0,0,4,4,0,0,4,4,4,4,0,0,4,4,4,3,3,4,4,4,4,4,4,4,4,4,3,3,4,4,4,4,4,4,4,4,4,3,3,1,1,
		4,4,4,0,4,4,4,4,0,4,3,3,4,3,0,4,4,4,4,4,3,3,3,3,3,0,4,4,0,0,3,4,4,0,4,4,0,3,3,3,4,4,4,4,4,0,0,4,3,3,4,4,4,4,0,4,4,4,0,4,4,4,4,4,
		3,4,4,3,3,4,4,4,4,4,4,3,3,4,4,4,4,4,4,4,4,3,3,3,3,3,4,4,4,4,3,3,4,4,4,4,4,3,3,3,4,4,4,3,4,0,0,0,4,4,4,4,4,4,3,4,0,4,4,4,4,4,4,4,
		4,3,4,4,4,4,4,4,4,4,4,3,4,0,4,4,4,4,3,4,0,4,1,1,1,1,1,4,4,4,3,3,4,4,4,4,4,4,4,4,4,1,1,1,1,1,4,4,4,4,0,4,4,4,3,4,4,4,4,4,4,4,4,4,
		4,3,4,4,4,4,3,3,4,4,0,4,4,4,4,4,4,3,3,4,4,4,4,1,1,1,4,4,0,4,4,4,4,4,4,4,4,4,4,4,4,4,1,1,1,3,3,4,4,4,4,4,4,3,3,4,4,4,4,3,4,4,4,4,
		4,4,4,4,4,4,4,3,4,4,0,4,4,4,4,4,3,3,4,4,4,4,4,4,4,4,3,3,0,4,4,4,0,4,4,3,3,4,3,4,4,4,4,4,4,4,4,4,0,4,4,4,4,1,1,1,1,4,4,3,4,0,4,4,
		4,0,4,4,4,4,4,3,3,4,4,4,1,1,1,1,1,1,4,4,0,4,4,4,4,4,4,3,4,4,4,4,0,4,0,3,3,3,3,4,4,4,4,4,4,4,4,4,0,4,4,4,4,4,1,7,1,4,4,3,0,4,4,4,
		1,1,4,4,4,0,4,4,3,4,0,4,4,1,1,1,1,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,0,0,4,3,3,3,3,3,4,4,4,3,4,4,4,4,4,4,4,4,4,4,0,1,7,1,1,1,1,1,1,1,
		7,1,0,4,4,4,4,4,4,4,4,4,4,4,4,0,3,0,4,4,4,4,4,4,0,4,4,3,3,3,3,3,4,0,0,3,3,3,3,4,4,0,4,3,4,0,4,4,4,4,4,3,3,4,4,4,1,1,1,1,1,1,1,7,
		7,1,0,4,3,3,4,0,4,4,4,4,4,4,3,3,0,4,4,4,4,4,4,0,4,4,4,3,3,3,3,3,3,0,3,3,3,3,3,4,4,0,0,3,0,0,4,4,0,4,4,4,3,4,4,4,4,4,4,4,4,4,1,7,
		7,1,4,4,4,1,1,1,1,1,4,4,4,4,3,4,4,4,4,4,4,4,4,0,4,1,1,1,1,1,1,1,3,3,3,3,1,1,1,1,1,1,1,3,3,4,4,4,4,4,4,4,3,4,4,4,4,4,4,4,0,4,1,7,
		7,1,4,4,4,4,1,1,1,4,4,4,3,3,4,4,4,4,4,4,4,4,4,0,0,0,1,1,1,1,1,3,3,3,3,3,3,1,1,1,1,1,4,4,3,4,4,4,4,4,4,4,3,4,4,0,4,4,4,0,0,4,1,7,
		7,1,4,4,4,4,3,4,4,4,4,0,3,3,0,4,4,0,3,3,4,4,0,0,0,0,0,0,0,3,3,3,3,3,3,3,3,3,4,0,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,0,4,4,1,7,
		7,1,0,4,4,4,4,4,4,0,0,3,3,3,3,0,0,3,3,3,4,0,0,0,0,0,0,0,0,0,3,3,3,3,3,3,3,3,0,0,0,4,4,4,4,4,4,4,4,4,4,0,4,4,4,4,4,4,4,4,4,4,1,7,
		7,1,0,0,0,0,4,4,4,4,0,3,3,3,3,3,3,3,3,3,0,0,0,0,0,0,0,0,0,0,3,3,3,3,3,3,3,0,0,0,0,4,4,4,0,4,4,4,3,3,4,0,0,4,3,3,4,0,0,4,3,4,1,7,
		7,1,0,0,0,0,0,4,4,4,3,3,3,3,3,3,3,3,3,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,3,3,3,0,0,0,0,0,0,4,4,4,4,3,3,3,3,0,0,1,1,1,3,0,0,3,3,3,1,7,
		7,1,0,0,0,0,0,0,0,0,3,3,3,3,3,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,3,1,1,1,1,3,0,0,0,0,0,0,0,0,4,4,3,3,3,3,3,0,1,7,1,3,3,3,3,3,3,1,7,
		7,1,0,0,0,0,0,0,0,0,3,3,3,3,3,1,7,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,3,1,1,1,1,1,7,1,3,3,3,3,3,3,3,1,7,
		7,1,0,0,0,0,0,0,0,0,1,1,1,1,1,7,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,3,3,0,0,0,0,0,0,0,0,0,0,0,3,1,1,1,1,1,3,3,3,3,3,3,3,3,1,7,
		7,1,0,0,0,0,0,0,0,0,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,3,3,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,3,3,3,3,3,3,3,0,1,7,
		7,1,0,0,0,0,0,0,0,0,0,3,3,3,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,3,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,3,3,0,0,0,0,1,7,
		7,1,0,0,0,0,0,0,0,0,0,3,3,3,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,3,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,0,0,0,0,0,1,7,
		7,1,0,0,0,0,0,0,0,0,0,3,3,3,3,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,3,3,3,3,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,3,3,3,3,0,0,0,0,0,1,7,
		7,1,0,0,0,0,0,0,0,0,0,3,3,3,3,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,3,3,3,3,3,3,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,0,0,0,0,0,1,7,
		7,1,0,0,0,0,0,0,0,0,0,3,3,3,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,3,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,0,0,0,0,0,1,7,
		1,1,0,0,0,0,0,0,0,0,0,3,3,3,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,3,3,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,0,0,0,0,0,1,1,
		0,0,0,0,0,0,1,1,1,1,1,1,1,3,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,3,3,3,3,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,
		0,0,0,0,0,0,0,1,1,1,1,1,3,3,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,1,1,3,3,3,3,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,
		0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,0,0,0,1,1,1,1,0,0,0,0,0,0,0,3,3,3,3,1,1,3,3,3,3,3,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,0,0,0,0,0,0,0,
		0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,0,0,0,1,7,7,1,0,0,0,0,0,3,3,3,3,1,1,1,1,1,1,3,3,3,3,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,0,0,0,0,0,0,0,
		0,0,0,0,0,0,0,0,0,0,3,3,3,3,3,3,0,0,1,7,7,1,0,0,0,0,3,3,3,3,3,1,7,7,7,7,1,3,3,3,3,3,3,0,0,0,0,0,0,0,0,0,3,3,3,3,3,3,0,0,0,0,0,0,
		0,0,0,0,0,0,0,0,3,3,3,3,3,3,3,3,3,3,1,7,7,1,0,0,3,3,3,3,3,1,1,7,7,7,7,7,7,1,1,3,3,3,3,3,0,0,0,0,0,0,0,3,3,3,3,3,3,3,3,3,0,0,0,0,
		1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,7,7,7,7,1,1,1,1,1,1,1,7,7,7,7,7,7,7,7,7,7,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
		7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7,7

	};

	public static byte[] levelThree = {

		
		6,6,6,6,6,6,6,6,6,6,6,6,6,6,2,5,5,5,5,5,5,2,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,2,5,0,0,5,5,5,2,6,6,6,6,6,6,6,6,6,6,
		6,2,2,2,2,2,2,2,2,2,2,2,2,2,2,5,5,5,5,5,5,2,6,2,2,2,6,6,6,6,6,6,6,6,6,6,6,6,6,2,2,2,2,2,2,6,2,5,5,0,5,5,5,2,2,2,2,2,2,2,2,2,2,6,
		6,2,0,0,0,0,0,5,5,5,5,5,5,5,5,5,5,5,5,2,2,6,2,5,5,5,2,2,6,6,6,6,6,6,6,6,6,6,2,5,0,5,5,5,5,2,6,2,2,0,5,5,5,5,5,5,5,5,5,0,0,0,2,6,
		6,2,0,0,0,0,0,5,5,5,5,5,5,5,5,5,5,5,0,2,2,2,2,5,5,5,0,0,2,6,6,6,6,6,6,6,6,6,2,5,5,0,5,5,5,2,2,2,2,0,0,5,5,5,5,5,5,5,5,5,0,0,2,6,
		6,2,0,0,0,0,0,5,5,5,5,5,5,5,5,5,5,5,0,0,0,0,5,5,5,5,5,0,2,6,6,6,6,6,6,6,6,2,2,5,5,0,0,5,5,5,5,5,5,5,0,5,5,5,5,5,5,5,5,5,5,0,2,6,
		6,2,0,0,0,0,5,5,5,5,5,5,5,5,5,5,5,0,0,0,0,0,5,5,5,5,5,5,5,2,2,6,6,6,6,6,2,5,5,5,5,5,0,0,5,5,5,5,5,5,0,5,5,5,5,5,5,5,5,5,5,5,2,6,
		6,2,0,0,0,2,2,2,2,2,5,5,5,5,5,5,5,0,0,0,0,0,5,5,5,5,5,5,5,5,5,2,6,6,6,2,2,5,5,5,5,5,5,0,0,5,5,5,5,5,0,0,5,5,5,5,5,5,5,5,5,5,2,6,
		6,2,0,0,5,5,2,2,2,2,2,2,2,2,2,5,5,5,0,0,0,5,5,5,5,2,5,5,5,5,5,2,6,6,2,5,5,5,5,5,5,5,5,5,0,0,5,5,5,5,5,0,5,5,5,5,5,5,5,5,5,5,2,6,
		6,2,0,0,5,5,5,5,5,5,2,2,2,2,5,5,5,5,0,0,0,5,5,5,5,2,2,5,5,5,5,2,6,6,2,5,5,5,5,5,5,5,2,5,5,0,0,5,2,2,2,2,2,2,2,2,5,5,5,5,5,5,2,6,
		6,2,0,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,0,0,5,2,2,2,2,6,2,0,5,5,5,2,2,6,2,5,5,5,5,5,5,5,2,2,5,5,0,5,5,2,2,2,2,2,2,5,5,5,5,0,0,5,2,6,
		6,2,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,0,5,5,2,2,2,2,0,0,0,5,5,0,0,2,2,0,5,5,2,2,2,2,6,2,5,5,0,5,5,5,5,0,5,5,5,5,0,0,0,0,5,0,2,6,
		6,2,5,5,5,5,5,5,5,0,0,0,0,0,5,5,5,5,5,5,5,5,5,5,5,0,0,0,5,5,5,0,0,2,2,0,0,0,5,2,2,2,2,5,5,5,0,5,5,5,5,0,0,5,0,0,0,5,5,5,5,5,2,6,
		6,2,5,5,5,5,5,5,5,0,0,0,0,0,5,5,2,2,2,5,5,5,5,5,5,5,0,5,5,5,5,0,0,2,5,5,0,0,0,0,5,5,5,5,5,5,0,0,5,0,0,0,0,0,0,5,5,5,5,5,5,5,2,6,
		6,2,5,5,5,5,5,5,5,5,5,5,5,5,5,5,2,6,2,5,5,5,5,5,5,5,5,5,5,5,5,0,0,0,5,5,5,5,5,0,0,0,0,0,5,0,0,0,0,0,5,5,5,5,5,5,5,5,5,5,5,5,2,6,
		6,2,5,5,5,5,5,5,5,5,5,5,5,5,5,5,2,6,6,2,5,5,5,5,5,5,5,5,5,5,5,0,0,0,5,5,5,5,5,5,5,5,5,0,0,0,0,0,0,0,5,5,5,5,5,5,5,5,5,2,2,2,6,6,
		6,2,5,5,5,5,5,5,5,5,5,5,5,5,5,5,2,6,2,5,5,5,5,5,5,5,5,5,5,5,5,0,0,5,0,5,5,5,5,5,5,5,0,0,5,5,0,5,5,0,0,0,0,0,0,5,5,5,5,2,6,6,6,6,
		6,6,2,2,2,2,5,5,5,5,2,2,2,2,2,2,6,2,5,5,5,5,5,5,5,5,5,5,5,5,5,0,5,0,0,5,5,5,5,5,5,0,0,5,5,5,0,0,5,5,5,5,5,0,0,0,0,0,0,2,6,6,6,6,
		6,6,2,2,2,5,5,5,5,5,5,2,2,2,2,2,2,0,0,5,5,5,5,5,5,5,5,5,5,5,5,0,5,0,0,0,5,5,0,0,0,0,5,5,5,5,5,0,5,5,5,5,5,5,5,5,0,0,0,2,6,6,6,6,
		6,2,5,5,5,5,5,5,5,0,0,5,5,5,5,5,0,0,0,0,5,5,5,5,5,5,5,5,5,5,5,5,5,0,0,0,5,0,0,5,2,2,2,2,2,2,2,2,2,5,5,5,5,5,5,5,2,2,2,6,6,6,6,6,
		6,2,5,5,5,5,5,5,0,0,0,5,5,5,5,5,5,0,0,0,0,0,5,5,5,5,5,5,5,5,5,5,2,0,0,0,0,0,5,5,5,5,2,2,2,2,2,2,5,5,5,5,5,5,5,5,2,2,6,6,6,6,6,6,
		6,2,5,5,5,5,5,0,0,0,5,5,5,5,5,5,5,5,0,0,0,0,5,2,2,2,2,5,5,5,5,5,2,2,0,0,0,5,5,5,5,5,5,0,0,0,5,0,0,5,5,5,5,2,2,2,5,5,2,6,6,6,6,6,
		6,2,5,5,5,5,0,0,0,5,5,5,0,0,5,5,5,5,5,0,0,0,5,2,6,2,5,5,5,5,5,5,6,6,2,0,5,5,5,5,5,5,5,0,5,5,5,5,0,5,5,5,5,5,5,5,5,5,5,2,6,6,6,6,
		6,2,5,5,5,0,0,0,5,5,5,5,0,0,0,5,5,5,5,2,2,2,2,6,2,5,5,5,5,5,2,2,6,6,2,0,5,5,5,5,5,5,0,0,5,5,5,5,0,5,5,5,5,5,5,5,5,5,5,5,2,6,6,6,
		6,2,5,5,0,0,0,5,5,5,5,5,5,0,0,0,5,5,5,5,2,2,2,2,5,5,5,5,5,5,2,6,6,6,2,0,5,5,5,5,5,5,0,5,5,5,5,5,5,0,5,5,5,5,5,5,5,5,5,5,5,2,6,6,
		6,2,5,0,0,0,5,5,5,5,5,5,5,5,0,0,0,5,5,5,5,5,5,5,5,5,5,5,5,5,2,6,6,6,2,0,5,5,5,5,5,0,0,5,5,5,5,5,5,0,5,2,2,2,2,2,2,5,5,5,5,5,2,6,
		6,2,5,5,0,5,5,2,2,2,2,2,2,5,5,0,0,0,5,5,5,5,5,5,5,5,5,5,5,5,2,6,6,6,6,2,2,2,5,5,0,0,5,2,2,2,2,2,5,0,5,5,2,6,6,2,5,5,5,5,5,5,2,6,
		6,2,5,5,5,5,5,5,2,2,2,2,5,5,5,5,0,5,5,5,5,5,5,5,5,5,5,2,2,2,6,6,6,6,6,6,6,2,5,0,0,5,5,5,2,6,6,2,5,5,0,0,5,2,6,2,5,5,5,5,5,5,2,6,
		6,2,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,0,0,5,5,5,5,2,6,6,6,6,6,6,6,6,6,2,0,5,0,5,5,5,5,2,6,2,5,5,5,0,5,2,6,2,5,5,5,5,0,0,2,6,
		6,2,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,0,0,0,5,5,5,5,2,6,6,6,6,6,6,6,6,6,2,5,5,0,5,5,5,5,5,2,2,5,5,5,0,0,5,2,2,5,5,5,5,0,0,2,6,
		6,2,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,0,0,0,0,5,5,5,5,2,6,6,6,6,6,6,6,6,6,6,2,2,2,5,5,5,5,5,5,2,5,5,5,5,0,5,2,2,5,5,5,0,0,0,2,6,
		6,2,5,5,5,5,5,5,5,5,5,5,5,5,5,2,2,5,0,0,0,0,5,5,5,2,2,6,6,6,6,6,6,6,6,6,6,6,6,6,2,5,5,5,5,5,5,5,5,5,5,5,0,5,2,2,5,5,5,0,0,0,2,6,
		6,2,5,5,0,0,0,0,5,5,5,5,5,5,5,2,2,5,0,0,0,0,5,5,5,2,6,6,6,6,6,6,6,6,6,6,6,6,6,6,2,5,5,5,5,5,5,5,5,5,5,5,0,0,5,5,5,5,5,5,5,5,2,6,
		6,2,5,5,0,0,0,0,5,5,5,5,5,5,5,2,2,5,0,0,0,5,5,5,5,2,6,6,6,6,6,6,6,6,6,6,6,6,6,6,2,5,5,5,5,5,5,5,5,5,5,5,5,0,0,5,5,5,5,5,5,5,2,6,
		6,2,5,5,0,0,0,0,5,5,5,5,5,5,5,2,2,5,5,5,5,5,5,5,5,2,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,2,2,2,2,5,5,5,5,5,5,5,5,5,0,0,5,5,5,5,5,5,2,6,
		6,2,2,2,0,0,0,0,5,5,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,2,2,2,2,2,2,2,2,2,5,5,5,5,5,5,2,2,2,6,
		6,6,6,2,0,0,0,0,5,5,2,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,2,5,5,0,5,5,5,2,6,6,6
	};
}