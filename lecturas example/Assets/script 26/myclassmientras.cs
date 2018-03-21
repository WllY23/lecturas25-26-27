using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myclassmientras : MonoBehaviour
{

	void Start ()
	{
		int[] scores = new int[10];
		int i = 0;
		while (i < 10)
		{
			scores [i] = Random.Range (0,100);
			Debug.Log (scores[i]);
			i++;
		}
	}

	void Update () 
	{
		
	}
}
