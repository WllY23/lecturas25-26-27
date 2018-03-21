using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : MonoBehaviour 
{
	public static int numzombie;
    public bool die;
    public GameObject player;
    public float speed = 0.01f;
	void Start () 
	{
        player = GameObject.Find("Main Camera");
        numzombie++;
		Debug.Log (numzombie);
	}
	

	void Update () 
	{
		//revisa cuando es pulsada la tecla a
		bool akey = Input.GetKey(KeyCode.A);
		if (akey) 
		{
			Debug.Log (akey);
			// llama la funcion estatica zombie
		}
        Vector3 direccion = (player.transform.position - transform.position).normalized;
        float distance = (player.transform.position - transform.position).magnitude;
        Vector3 move = transform.position + (direccion * speed);
        transform.position = move;
        if (distance < 1f)
        {
            die = true;
        }
        if (die)
        {
            numzombie--;
            Destroy(gameObject);
        }
    }

    public static void Countzombies ()
        {
        Debug.Log(numzombie);
        }
}
