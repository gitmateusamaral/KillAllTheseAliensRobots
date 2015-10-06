using UnityEngine;
using System.Collections;

public class Sh_Behavior : MonoBehaviour {

	void Update () 
	{
		transform.Translate(new Vector2(0.2f,0));
		
		if(transform.position.x > 10f)
		{
			Destroy(gameObject);
		}
	}
	
	void OnTriggerEnter2D (Collider2D col)
	{
		if(col.gameObject.tag == "Enemy")
		{
			Destroy (gameObject);
		}
	}
}
