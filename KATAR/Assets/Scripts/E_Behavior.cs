using UnityEngine;
using System.Collections;

public class E_Behavior : MonoBehaviour {

	public float l = 0.05f;
	public GameObject Bo;

	void Update()
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
		if(col.gameObject.tag == "ShootP" || col.gameObject.tag == "LaserP")
		{
			Destroy(gameObject);
			Bo.transform.position = gameObject.transform.position;
			Instantiate(Bo);
		}
		if(col.gameObject.tag == "Player")
		{
			Destroy(gameObject);
			if(GameObject.FindWithTag("StarShip").GetComponent<S_Behavior>().life <= 1)
			{
 				Application.LoadLevel(0);
			}
			else
				GameObject.FindWithTag("StarShip").GetComponent<S_Behavior>().life -= 1;
		}
	}
}