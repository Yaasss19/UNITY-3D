using System.Collections;
using UnityEngine;

public class FallingFlour : MonoBehaviour
{
    private Renderer rend;
    private float disappearanceTimer = 1f;
    private float disappearanceTimer2 = 1f;
    
    void Start()
    {
        rend = GetComponent<Renderer>();
    }
    
    void OnCollisionEnter(Collision collision)
    {
    	foreach (ContactPoint contact in collision.contacts)
		{
            rend.material.color = new Color(1f, 0.5f, 0f); //Orange
			StartCoroutine(Disappear());
		}
    }
    
    IEnumerator Disappear()
    {
        yield return new WaitForSeconds(disappearanceTimer);
        rend.material.color = Color.red;
        StartCoroutine(Disappear2());
    }

    IEnumerator Disappear2()
    {
        yield return new WaitForSeconds(disappearanceTimer2);
        Destroy(gameObject);
    }
}