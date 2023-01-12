using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FliperMove : MonoBehaviour
{
	public float speed = 1.5f;
	public float limit = 45f; //Limit in degrees of the movement
	public bool isStart = true;
	public bool isWaiting = false;


    // Update is called once per frame
    void Update()
    {

		if (!isWaiting)
		{
			if(isStart)
			{
				if(transform.rotation.ToEuler().y*Mathf.Rad2Deg < 90)
					transform.Rotate(0f, speed * Time.deltaTime / 0.01f,0f, Space.Self);
				else
				{
					isStart=false;
				}
			}
			else
			{
				if (transform.rotation.ToEuler().y*Mathf.Rad2Deg > 0)
					transform.Rotate(0f, -speed/5 * Time.deltaTime / 0.01f,0f, Space.Self);
				else
				{
					StartCoroutine(WaitForRotate());
				}
			}
		}
    }
	IEnumerator WaitForRotate()
	{
		isWaiting = true;
		yield return new WaitForSeconds(2);
		isWaiting = false;
		isStart = true;
	}

}
