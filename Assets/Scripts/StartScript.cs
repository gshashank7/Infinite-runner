using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour {

	void OnGUI ()
	{
		if (GUI.Button (new Rect (Screen.width / 2 - 30, 300, 60, 30), "PLAY")) 
		{
			Application.LoadLevel(1);
		}
	}
}
