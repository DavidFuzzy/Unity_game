using UnityEngine;
using System.Collections;

public class scores1 : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D hitInfo) {
		if (hitInfo.name == "ball2")
		{
			string wallName = transform.name;
			GameManager1.Score(wallName);
			hitInfo.gameObject.SendMessage("RestartGame", 1.0f, SendMessageOptions.RequireReceiver);
		}
	}
}