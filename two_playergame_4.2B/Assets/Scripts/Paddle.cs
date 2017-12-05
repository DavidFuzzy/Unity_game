using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    public float paddlespeed = 1;
    public Vector3 PlayerPos;

    // Update is called once per frame
    void Update()
    {
        float yPos = transform.position.y + (Input.GetAxis("Vertical") * paddlespeed);
		PlayerPos = new Vector3(-17, Mathf.Clamp(yPos,-7.93f, 7.93f), 0);
        gameObject.transform.position = PlayerPos;
    }
}