using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class constructores : MonoBehaviour 
{
	int i= new int();


	void Start () 
	{
		Debug.Log(i);
		Vector3  Vector = new Vector3(1,2,3);
		Vector.x = 1.0f;
		transform.position = Vector;
	}
	

	void Update () 
	{
		
	}
}
