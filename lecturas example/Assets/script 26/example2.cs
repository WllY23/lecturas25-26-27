using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class example2 : MonoBehaviour 
{
	int MyAdd(int a, int b)
	{
		return a+b;
	}

	void Start () 
	{
		// estas 2 lineas imprimen igual un 13
		//int a = MyAdd (6,7);
		Debug.Log (MyAdd(6,7));
	}
	

	void Update ()
	{
		
	}
}
