using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class example3 : MonoBehaviour
{
    public GameObject[] gos;

	void Start ()
    {
        gos = new GameObject[10];
        for (int i = 0;i<10; i++)
        {
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 V = new Vector3();
            V.x = Random.Range(-10,10);
            V.z = Random.Range(-10, 10);
            go.transform.position = V;
            go.name = i.ToString();
            if (i % 2 == 0)
            {
                go.AddComponent(typeof(zombiedata));
            }
            gos [i] = go;

        }
	}

    void Update()
    {
        foreach (GameObject go in gos)
        {
            zombiedata zd = (zombiedata)go.GetComponent(typeof(zombiedata));
            if (zd == null)
            {
                continue;
            }
            if (zd.hitpoints < 0)
            {
                zd.hitpoints = 10;
                break;
            }
                 Debug.Log(go.name);
        }
	}
}
