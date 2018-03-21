using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSAim : MonoBehaviour {
    float MouseX;
    float MouseY;
    public bool invertemouse;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Vector3 mousePosition = Input.mousePosition;
        //Debug.Log(mousePosition);
        //float mouseX = mousePosition.x;
        //float mouseY = mousePosition.y;
        //// en el isnspector podemos modificar la camara y jugar con dif valores en el componete transform
        //Debug.Log(transform.localRotation);
        //// rotacion de la camara utilizando euler
        //Debug.Log(transform.eulerAngles);
        //transform.eulerAngles = new Vector3 (30,0,0);
        //// rotacion de la camara el y con el mouse
        //transform.eulerAngles = new Vector3 (mouseY,0,0);
        MouseX += Input.GetAxis("Mouse X");
        if (invertemouse)
        {
            MouseY += Input.GetAxis("Mouse Y");
        }
        else
        {
            MouseY -= Input.GetAxis("Mouse Y");
        }
        //MouseY += Input.GetAxis("Mouse Y");
        Debug.Log(MouseX);
        transform.eulerAngles = new Vector3(MouseY, MouseX, 0);
	}
}
