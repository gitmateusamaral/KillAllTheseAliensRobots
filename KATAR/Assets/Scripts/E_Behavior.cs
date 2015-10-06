using UnityEngine;
using System.Collections;

public class E_Behavior : MonoBehaviour {

	public float l = 0.05f;

	void Update()
	{
		if(transform.position.y <= -4f || transform.position.y >= 3.3f )
		{
			l = -l;
		}
		
		transform.Translate(new Vector3(-0.025f,l,0));
	}

	void OnTriggerEnter2D(Collider2D col) 
	{
		if(col.gameObject.tag == "ShootP" || col.gameObject.tag == "Laser")
		{
			Destroy(gameObject);	
		}
	}
}