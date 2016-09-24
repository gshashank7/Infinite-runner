using UnityEngine;
using System.Collections;

public class TouchScript : MonoBehaviour {

	bool jump = false;
	 
void update()
	{
		if (Input.touchCount >= 1) {
				
			CrossPlatformInput.GetButtonDown("Jump");
			jump = true;
		}
	}
}
