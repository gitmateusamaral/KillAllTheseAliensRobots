using UnityEngine;
using System.Collections;

public class B_Behavior : MonoBehaviour 
{
	public GameObject PUp;

	Color temp;

	void Start()
	{
		temp = gameObject.GetComponent<SpriteRenderer> ().color;
		temp.a = 0;
		gameObject.GetComponent<SpriteRenderer> ().color = temp;
	}

	void Update () 
	{
		temp.a += 1.5f*Time.deltaTime;

		gameObject.GetComponent<SpriteRenderer> ().color = temp;

		if(gameObject.GetComponent<SpriteRenderer>().color.a >= 1)
		{
			Destroy(gameObject);
			if(Random.Range(0,10) <= 1)
			{
				PUp.transform.position = gameObject.transform.position;
				Instantiate(PUp);
			}
		}
	}
}