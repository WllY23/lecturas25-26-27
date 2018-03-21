using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayList : MonoBehaviour
{
    // inicializacion de una aray list
    // ArrayList aList = new ArrayList();
    //public int[] number = new int[] { 1, 3, 4, 11, 13, 17 };
    // alist hereda los metodos mienbros del array
    // el metodo add para añadir valor al final del objeto ArrayList
    //int i = 3;
    //AList.Add(i);

    // guarda todos los game objet de la esena
    public GameObject[] allGameObject;

    void Start ()
    {
        //string s = "jhon william arias";
        // s += "mas palbreas";
        //bool b = s.Contains("algo");
        string s = "primera palabra" + "segunda palabra";
        Debug.Log (s);
       
        
        //crea arraylist
        //ArrayList aList = new ArrayList();
        List<GameObject> aList = new List<GameObject>();
        // crea un array con todos los objetos de la esena
        Object[] allObjets = GameObject.FindObjectsOfType(typeof(Object)) as Object[];
        
        // itera atraves de todos los objetos
        foreach (Object o in allObjets)
        {
            //si hay un gameobject se añade a la lista
            GameObject go = o as GameObject;
            if (go != null)
            { 
                Debug.Log(o);
                aList.Add(go);
            }
        }
        // iniciamos la matriz allgameobjects
        allGameObject = new GameObject[aList.Count];
        //copiar la lista a la matriz
        aList.CopyTo(allGameObject);
        
        
	}
	void Update ()
    {
		
	}
}
