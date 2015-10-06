using UnityEngine;
using System.Collections;

public class L_Behavior : MonoBehaviour {
		
	void FixedUpdate () 
	{
		transform.position = new Vector2(GameObject.FindWithTag("StarShip").transform.position.x - 1.7f, GameObject.FindWithTag("StarShip").transform.position.y + 1f);
	}
}