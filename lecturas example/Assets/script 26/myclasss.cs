using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myclasss : MonoBehaviour 
{
	public myclasss [] myclasses = new myclasss[10];
	public GameObject [] mygameobjects;
	public int [] primos = new int[]{1,3,5,7,11,13,17};

	void Start () 
	{
		Debug.Log (mygameobjects.Length);
		for (int i = 0; i < mygameobjects.Length; i++)
		{
			mygameobjects [i].name = i.ToString();
		}
		foreach (GameObject go in mygameobjects) 
		{
			Debug.Log (go.name);
		}
	}

	void Update () 
	{
		
	}
}
