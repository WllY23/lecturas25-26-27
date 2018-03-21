using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour 
{
	// posicion del player
	Vector3 pos;

	void Start ()
	{
  
        
		pos = transform.position;

	}
	

	void Update ()
	{
		// revisomos uso de la tecla a
//		bool akey = Input.GetKey(KeyCode.A);
//		if (akey) 
//		{
//			Debug.Log ("akey");
//		}

//		Input myimput = new Input ();
//		bool akey = myimput.GetKey(KeyCode.A);
		bool wkey = Input.GetKey(KeyCode.W);
		bool skey = Input.GetKey(KeyCode.S);
		bool akey = Input.GetKey(KeyCode.A);
		bool dkey = Input.GetKey(KeyCode.D);

		if (wkey)
		{
			pos.z += 0.1f;
		}
		if (skey)
		{
			pos.z -= 0.1f;
		}
		if (akey)
		{
			pos.x -= 0.1f;
		}
		if (dkey)
		{
			pos.x += 0.1f;
		}
		gameObject.transform.position = pos;
	}

	void staicc ()
	{
		for (int i=0; i<10; i++)
		{
			print (i); // imprime num de 1 al 10
		}
		// i ya no existe print (i); error, i no ha sido definida
	}
}
