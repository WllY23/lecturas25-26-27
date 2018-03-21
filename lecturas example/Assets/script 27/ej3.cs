using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej3 : MonoBehaviour
{


	void Start ()
    {
        GameObject a = new GameObject("A");
        GameObject b = new GameObject("B");
        GameObject c = new GameObject("C");
        GameObject d = new GameObject("D");
        GameObject e = new GameObject("E");
        GameObject f = new GameObject("F");
        GameObject[,] twoDimencion = new GameObject[2, 3]
        {{a,b,c},{d,e,f} };
        InspectArray(twoDimencion);
    }
    void InspectArray(GameObject[,] gos)
    {
        int columns = gos.GetLength(0);
        Debug.Log("columns: " + columns);
        int rows = gos.GetLength(1);
        Debug.Log("Rows: " + rows);
        for (int c=0; c < columns; c++)
        {
            for (int r = 0; r < columns; r++)
            {
                Debug.Log(gos [c, r].name);
            }
        }
    }
    void Update()
    {

    }
}
	

