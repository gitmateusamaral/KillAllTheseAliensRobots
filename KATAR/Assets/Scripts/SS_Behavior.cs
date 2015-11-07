using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class SS_Behavior : MonoBehaviour 
{

	public AudioClip sound;
	
	void Start()
	{
		sound = (AudioClip)Resources.Load("sound");;	
	}
	
	public void StartS(int scene)
	{
			Application.LoadLevel(scene);
	}
	
}
