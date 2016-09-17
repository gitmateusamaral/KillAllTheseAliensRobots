using UnityEngine;
using System.Collections;

public class Main_Behavior : MonoBehaviour 
{
	public GameObject e;

	private float SpT;

	void Start()
	{
		SpT = Random.Range(0,7);
	}

	void Spawn()
	{
		e.transform.position = new Vector3 (11,-3.8f,0);
		Instantiate (e);
	}

	void Update()
	{
		SpT -= Time.deltaTime*8;

		if(SpT <= 0)
		{
			SpT = Random.Range(0,7);
			Spawn();
		}
	}
}