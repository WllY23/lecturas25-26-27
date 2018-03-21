using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timers : MonoBehaviour

{
    public float nextTime = 0f;
    public float timer = 0.5f;
    public int counter = 10;
    public int minHeight = 1;
    public int maxHeight = 10;
    public float horizontalSpacing = 2f;
    public float verticalspacing = 1f;
    void Start()
    {
        string s = @"this that and the other";
        Debug.Log (s);
		
	}
    
	void Update ()
    {
        if (counter > 0 && Time.fixedTime > nextTime)
        {
          //  if (Time.fixedTime > nextTime)
            nextTime = Time.fixedTime + timer;
            //Debug.Log("se acabo le tiempo");
            int randomNumber = Random.Range(minHeight,maxHeight);
            for (int i = 0; i < randomNumber; i++)
            {
                GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);
                box.transform.position = new Vector3(counter * horizontalSpacing, i * verticalspacing, 0);
            }
            counter--;
        }

    }
}

