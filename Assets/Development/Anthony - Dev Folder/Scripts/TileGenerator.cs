using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEditor;

public class TileGenerator : MonoBehaviour {

	[Range(100,10000)]
	public int iChunkWidth;

	[Range(0,50)]
	public int iVerticalChunksPerTier;

	[Range(10,10000)]
	public int iTierAmmounts;
		

}
