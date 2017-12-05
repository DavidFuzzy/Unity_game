using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	public Vector3 PlayerPos;

	// Update is called once per frame
	void Update()
	{
		//save the mouse position in unity units
		//(depending on the number of units on screen
		float mousePosInUnits = (Input.mousePosition.y / Screen.height * 24.7f) - 12.35f;

		//creates a Vector3 which saves a coordinate
		//in (x,y,z)
		//this.transform.position.y: keeps the starting y-value
		Vector3 paddlePosition = new Vector3(17f, this.transform.position.y, 0f);

		paddlePosition.y = Mathf.Clamp(mousePosInUnits, -7.93f,7.93f);

		//set the position of the paddle
		this.transform.position = paddlePosition;
	}
}

