using UnityEngine;
using System.Collections;

public class PUp_Behavior : MonoBehaviour 
{
	public float l = 0.05f;

	void Update () 
	{
		if(transform.position.y <= -4f || transform.position.y >= 3.3f )
		{
			l = -l;
		}
		
		transform.Translate(new Vector3(-0.025f,l,0));
		if(this.transform.position.x <= -9.5f)
		{
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D col) 
	{
		if(col.gameObject.tag == "Player")
		{
			Destroy(gameObject);
			GameObject.FindWithTag("StarShip").GetComponent<S_Behavior>().lShots += 1;
		}
	}
}