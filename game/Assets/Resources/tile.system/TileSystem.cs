using UnityEngine;
using System.Collections;

public class TileSystem : MonoBehaviour {
	private GameObject[] tiles;
	private GameObject tile;
	private int Xrow;
	private int Ynum;
	private Vector3 tilePos;
	private float tileWidth = 0.2f;
	private float tileHeight = 0.2f;
	public static int whatLevel = 1;

	void Start(){

		tiles = new GameObject[2304];
	}

	public void RemoveLevel(){

		for(int i = 0; i < tiles.Length;i ++){

			DestroyObject(tiles[i]);
		}
		tilePos  = new Vector3(0, 0, 0);
		Xrow = 0;
		Ynum = 0;
	}

	public void ChangeLevel(int level){

		whatLevel = level;
	}

	public void ChooseLevelCreation(){

		if(whatLevel == 1){
			
			Readtile(TileLevel.levelOne);
		} else if(whatLevel == 2){
			
			Readtile(TileLevel.levelTwo);
		} else if(whatLevel == 3){
			
			Readtile(TileLevel.levelThree);
		}
	}

	void Readtile(byte[] level){

		for(int i = 0; i < 2304; i ++){

			Xrow ++;
			int straightener = 0;
			if(tilePos.y < 0){

				straightener = 1;
			}

			if(Xrow > 64-straightener){

				Ynum += 1;
				tilePos.y -= tileHeight;
				tilePos.x = 0;
				Xrow = 0;
			}

			CreateTile(level[i], i);
			tilePos.x += tileWidth;
		}
	}
	//0:empty
	//1:ground tile grass
	//2:ground tile stone
	//3:background tile tree
	//4:background tile leafs
	//5:background tile stone 
	//6:ground tile stone without collider
	//7:ground tile grass without collider

	void CreateTile(byte ID, int tileID){

		switch(ID){

		case 1:
			GameObject groundTileGrass = Instantiate(Resources.Load("tile.prefabs/groundTileGrass"), tilePos, transform.rotation) as GameObject;
			groundTileGrass.name = "groundTileGrass";
			groundTileGrass.gameObject.transform.parent = transform.GetChild(0).transform;
			tiles[tileID] = groundTileGrass.gameObject;
			break;
		case 2:
			GameObject groundTileStone = Instantiate(Resources.Load("tile.prefabs/groundTileStone"), tilePos, transform.rotation) as GameObject;
			groundTileStone.name = "groundTileStone";
			groundTileStone.gameObject.transform.parent = transform.GetChild(2).transform;
			tiles[tileID] = groundTileStone.gameObject;
			break;
		case 3:
			GameObject backgroundTileTree = Instantiate(Resources.Load("tile.prefabs/backgroundTileTree"), tilePos, transform.rotation) as GameObject;
			backgroundTileTree.name = "backgroundTileTree";
			backgroundTileTree.gameObject.transform.parent = transform.GetChild(1).transform;
			tiles[tileID] =  backgroundTileTree.gameObject;
			backgroundTileTree.transform.position += new Vector3(0, 0, 10);
			break;
		case 4:
			GameObject backgroundTileLeafs = Instantiate(Resources.Load("tile.prefabs/backgroundTileLeafs"), tilePos, transform.rotation) as GameObject;
			backgroundTileLeafs.name = "backgroundTileLeafs";
			backgroundTileLeafs.gameObject.transform.parent = transform.GetChild(1).transform;
			tiles[tileID] = backgroundTileLeafs.gameObject;
			backgroundTileLeafs.transform.position += new Vector3(0, 0, 10);
			break;
		case 5:
			GameObject backgroundTileStone = Instantiate(Resources.Load("tile.prefabs/backgroundTileStone"), tilePos, transform.rotation) as GameObject;
			backgroundTileStone.name = "backgroundTileStone";
			backgroundTileStone.gameObject.transform.parent = transform.GetChild(1).transform;
			tiles[tileID] = backgroundTileStone.gameObject;
			backgroundTileStone.transform.position += new Vector3(0, 0, 10);
			break;
		case 6:
			GameObject groundTileStoneWithoutCollider = Instantiate(Resources.Load("tile.prefabs/groundTileStoneWithoutCollider"), tilePos, transform.rotation) as GameObject;
			groundTileStoneWithoutCollider.name = "groundTileStoneWithoutCollider";
			groundTileStoneWithoutCollider.gameObject.transform.parent = transform.GetChild(0).transform;
			tiles[tileID] = groundTileStoneWithoutCollider.gameObject;
			break;
		case 7:
			GameObject groundTileGrassWithoutCollider = Instantiate(Resources.Load("tile.prefabs/groundTileGrassWithoutCollider"), tilePos, transform.rotation) as GameObject;
			groundTileGrassWithoutCollider.name = "groundTileGrassWithoutCollider";
			groundTileGrassWithoutCollider.gameObject.transform.parent = transform.GetChild(0).transform;
			tiles[tileID] = groundTileGrassWithoutCollider.gameObject;
			break;

		}
	}
}
