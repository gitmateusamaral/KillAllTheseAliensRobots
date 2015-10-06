using UnityEngine;
using System.Collections;

public class S_Behavior : MonoBehaviour {

	public GameObject Shoot;
	public GameObject Laser;
	private int S_Type = 0;
	public bool Ready = true;
	
	void Update ()
	{
		Movement();
		Attack ();
	}
	
	public void Movement()
	{
			if((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && transform.position.y < 4.2)
			{
				transform.Translate(new Vector2(0,0.1f));
			}
			if((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) && transform.position.y > -4.1)
			{
				transform.Translate(new Vector2(0,-0.1f));
			}
			if((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && transform.position.x < 10)
			{
				transform.Translate(new Vector2(0.1f,0));
			}
			if((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && transform.position.x > -3.8)
			{
				transform.Translate(new Vector2(-0.1f,0));
			}
	}
	
	public void Attack()
	{
		if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
			S_Type = 0;
		
		if(Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
			S_Type = 1;
	
			switch(S_Type)
			{
			
			case 0:
				if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.O))
				{
					Instantiate(Shoot, new Vector2(transform.position.x - 1.9f,transform.position.y - 0.2f), Quaternion.identity);
				}
				break;
				
			case 1:
				if((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.O)) && Ready == true)
				{
					Instantiate(Laser, new Vector2 (transform.position.x - 1.7f,transform.position.y + 1f), Quaternion.identity);
					Ready = false;
				}
				break;
			}
			if(Input.GetKeyUp(KeyCode.Space) || Input.GetKeyUp(KeyCode.O))
			{
				Destroy (GameObject.FindWithTag("Laser"));
				Ready = true;
			}
	}
}
