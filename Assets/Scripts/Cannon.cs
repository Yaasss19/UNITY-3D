using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    
    public GameObject ballSpawn;
    public GameObject spherePrefab;
    public float force = 10.0f;
	private bool isWaiting = false;
    public bool canShoot = false;

    void Update()
    {
        if(canShoot)
        {
            GameObject sphere = Instantiate(spherePrefab);
            sphere.transform.position = ballSpawn.transform.position;
            Rigidbody sphereRigidbody = sphere.GetComponent<Rigidbody>();

            Vector3 impulse = (transform.forward + Vector3.up) * force;
            sphereRigidbody.velocity = impulse;
            canShoot = false;
        }
        else if(!isWaiting)
            StartCoroutine(WaitForRotate());
    }

    IEnumerator WaitForRotate()
	{
		isWaiting = true;
		yield return new WaitForSeconds(5);
		isWaiting = false;
		canShoot = true;
	}
}