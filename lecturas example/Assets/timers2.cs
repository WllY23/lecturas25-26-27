using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timers2 : MonoBehaviour
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
        //string s = @"this that and the other";
        //Debug.Log(s);

    }
    void Update()
    {
        if (counter > 0 && Time.fixedTime > nextTime)
        {
            //  if (Time.fixedTime > nextTime)
            nextTime = Time.fixedTime + timer;
            //Debug.Log("se acabo le tiempo");
            for (int j = 10; j > 0; j--)
            {
                int randomNumber = Random.Range(minHeight, maxHeight);
                for (int i = 0; i < randomNumber; i++)
                {
                    //GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    Custombox cBox = new Custombox();
                    cBox.box.transform.position = new Vector3(counter * horizontalSpacing, i * verticalspacing, j * horizontalSpacing);
                    cBox.PickRandomColor();
                }
            }
            counter--;
        }
    }

        class Custombox
        { 
            public GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);
        
            public void PickRandomColor()
            {
                Color rc = new Color(Random.value, Random.value, Random.value, 1);
                box.GetComponent<Renderer>().material.color = rc;
            }
        }
 }



