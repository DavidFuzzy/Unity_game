using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour 
{
	public float ballVelocity = 1000;

	Rigidbody2D rb;
	bool isPlay;
	int randInt;


	void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
		randInt = Random.Range(1,3);
	}

	void Update()
	{
		if (Input.GetMouseButton(0) && isPlay == false)
		{
			transform.parent = null;
			isPlay = true;
			rb.isKinematic = false;
			if (randInt == 1)
			{
				rb.AddForce(new Vector3(ballVelocity, ballVelocity, 0));
			}
			if (randInt == 2)
			{
				rb.AddForce(new Vector3(-ballVelocity, -ballVelocity, 0));
			}
		}
	}
}