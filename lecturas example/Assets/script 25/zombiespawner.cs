using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiespawner : MonoBehaviour
{

	
	void Start ()
    {
		
	}
	
	
	void Update ()
    {
        if (zombie.numzombie < 4)
        {
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            go.AddComponent(typeof(zombie));
            go.transform.position = transform.position;
        }
	}
}
