using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMove : MonoBehaviour
{
	public float distance = 5f; //Distance that moves the object
	public float speed = 3f;

	private bool isForward = true; //If the movement is out
	private Vector3 startPos;

	void Start()
	{
		startPos = transform.position;
	}
    // Update is called once per frame
    void Update()
    {
        if (isForward)
		{
			if (transform.position.z < startPos.z + distance)
			{
				transform.position += Vector3.forward * Time.deltaTime * speed;
			}
			else
				isForward = false;
		}
		else
		{
			if (transform.position.z > startPos.z)
			{
				transform.position -= Vector3.forward * Time.deltaTime * speed;
			}
			else
				isForward = true;
		}
    }
}
