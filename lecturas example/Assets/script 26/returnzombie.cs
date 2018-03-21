using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class returnzombie : MonoBehaviour
{
	// retorna un zombie

	void Start ()
	{
		
	}

	zombie Getzombie()
	{
		return (zombie)GameObject.FindObjectOfType (typeof(zombie));
	}

	void Update () 
	{
		// zombie target = Getzombie(); puede ser una variable null o zombie
		zombie target = Getzombie();
		if (target != null)
		{
			//Debug.DrawLine (); comienza en una posicion y va a otra 
		Debug.DrawLine (transform.position, Getzombie().transform.position);
		}
	}


}
