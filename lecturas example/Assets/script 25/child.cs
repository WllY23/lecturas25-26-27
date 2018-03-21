using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class child : parent
{

	// Use this for initialization
	void Start ()
    {
        Debug.Log(someInt);
        parentability();
   
    }

    public void childability()
    {
        Debug.Log("tu no ers mi padre");
    }
  
    // Update is called once per frame
    void Update ()
    {
        
        
	}
}
