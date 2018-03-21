using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid2D : MonoBehaviour
{
	public int width;
	public int height;
	public GameObject puzzlepiece;
	private GameObject[,] grid;
	
	void Start ()
    {
		grid = new GameObject[width, height];
		for (int x = 0; x < width; x++) 
		{
			for (int y = 0; y < height; y++) 
			{
				GameObject go = GameObject.Instantiate (puzzlepiece) as GameObject;
				Vector3 position = new Vector3(x, y, 0);
				go.transform.position = position;
				grid [x,y] = go;
			}
		}
	}

	void Update ()
    {
		Vector3 mPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		UpdatePickedPiece(mPosition);
		//Debug.DrawLine (Vector3.zero, mPosition);
	}

	void UpdatePickedPiece(Vector3 position)
	{
		int x = (int) (position.x + 0.5f);
		int y = (int) (position.y + 0.5f);
	
		for (int _x = 0; _x < width; _x++) 
		{
			for (int _y = 0; _y < height; _y++) 
			{
				GameObject go = grid [_x, _y];
				go.GetComponent<Renderer> ().material.SetColor ("_Color", Color.white);
			}
		}
        if (x >= 0 && y >= 0 && x < width && y < height)
        {
            GameObject go = grid[x, y];
            go.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        }
    }
		
//	 if(x >= 0){if (y >= 0){if(x < width){if(y < height){
//	 GameObject go = grid[x,y];
//	 go.GetComponent<Renderer>().material.SetColor("_Color", Color.red);}}}}		
}

 