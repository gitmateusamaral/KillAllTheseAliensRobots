using UnityEngine;
using System.Collections;

public class SSOK_Behavior : MonoBehaviour 
{
	public Sprite[] Sp;
	void Update () 
	{
		gameObject.GetComponent<SpriteRenderer>().sprite = Sp[GameObject.FindWithTag("StarShip").GetComponent<S_Behavior>().life -1];
	}
}
