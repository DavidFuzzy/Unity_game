using UnityEngine;
using System.Collections;

public class scores2 : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D hitInfo) {
		if (hitInfo.name == "ball2")
		{
			string wallName = transform.name;
			GameManager2.Score(wallName);
			hitInfo.gameObject.SendMessage("RestartGame", 1.0f, SendMessageOptions.RequireReceiver);
		}
	}
}