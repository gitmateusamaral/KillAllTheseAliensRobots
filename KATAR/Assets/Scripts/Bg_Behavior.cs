using UnityEngine;
using System.Collections;

public class Bg_Behavior : MonoBehaviour 
{
	public GameObject NewBg;
	bool spawn = false;
	void Start () 
	{
		this.transform.position = new Vector3(9.45f,this.transform.position.y,this.transform.position.z);
	}

	void Update () 
	{
		this.transform.position += new Vector3(-1*Time.deltaTime,0,0);
		if(this.transform.position.x <= -9f && !spawn)
		{
<<<<<<< HEAD
			Instantiate(NewBg,new Vector3(this.transform.position.x + 50f,this.transform.position.y,this.transform.position.z),this.transform.rotation);
=======
			Instantiate(NewBg,new Vector3(this.transform.position.x + 35f,this.transform.position.y,this.transform.position.z),this.transform.rotation);
>>>>>>> origin/master
			spawn = true;
		}
	}
}