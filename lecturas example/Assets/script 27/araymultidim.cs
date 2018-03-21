using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class araymultidim : MonoBehaviour
{
    int[] twodimensionalarray;
    void Start()
    {
        GameObject[] oneDimension = new GameObject[5];
        for (int i = 0; i < oneDimension.Length; i++)
        {
            Debug.Log(i);
        }


        GameObject[,] TwoDimension = new GameObject[2, 3];
        for (int i = 0; i < TwoDimension.Length; i++)
        {
            Debug.Log(i);
        }

       
    }
    void Update()
    {

    }
}









