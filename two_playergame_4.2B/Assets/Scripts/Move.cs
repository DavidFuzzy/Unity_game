using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour 
{
	public int maxSpeed;

	private Vector3 startPosition;

	// Use this for initialization
	void Start () 
	{
		maxSpeed = 5;

		startPosition = transform.position;
	}

	// Update is called once per frame
	void Update ()
	{
		MoveVertical ();
	}

	void MoveVertical()
	{
		transform.position = new Vector3(transform.position.x, startPosition.y + Mathf.Sin(Time.time * maxSpeed));
		//transform.position = new Vector3(0, startPosition.y + Mathf.Sin(Time.time * maxSpeed), 0);

		if(transform.position.y > 1f)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y);
		}
		else if(transform.position.y < -1f)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y);
		}
	}
}