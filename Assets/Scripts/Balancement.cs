using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balancement : MonoBehaviour
{
	public float speed = 1.5f;
	public float limit = 75f; //Limit in degrees of the movement

    // Update is called once per frame
    void Update()
    {
		float angle = limit * Mathf.Sin(Time.time);
		transform.localRotation = Quaternion.Euler(0, 0, angle);
	}
}
