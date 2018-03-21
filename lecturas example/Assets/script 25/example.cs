using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class example : MonoBehaviour
{
    public GameObject childobjet;
	
	void Start ()
    {
		
        pianocat famouscat = new pianocat();
        famouscat.playpiano();
        famouscat.meow();
        Debug.Log(famouscat.paws);

        famouscat.playpiano();
        famouscat.meow();
        Debug.Log(famouscat.paws);
        GameObject[] gos = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];
        foreach (GameObject go in gos)
        {
            Debug.Log(go);
            Component comp = go.GetComponent(typeof(child));
			if (comp != null)
			{
				childobjet = go;
			}
        }
    }
	
	
	public class cat 
    {
        public int paws = 4;
       public void meow()
        {
            Debug.Log("miau");
        }
	}
    public class pianocat:cat
    {
        public void playpiano()
        {
            meow();
        }      
    }
}
