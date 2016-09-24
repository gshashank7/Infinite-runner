using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	int score = 0;
	int coin = 0;

	void Start () {
	
	score = PlayerPrefs.GetInt("Score");
		coin = PlayerPrefs.GetInt ("Coins");
	}
	
	void OnGUI ()

	{
		GUI.Label(new Rect(Screen.width/2 - 40, 50, 80, 30), "GAME OVER");
		GUI.Label(new Rect(Screen.width/2 - 40, 300, 80, 30), "DISTANCE " + score);
		GUI.Label(new Rect(Screen.width/2 - 40, 370, 80, 30), "COINS: " + coin);
		if (GUI.Button (new Rect (Screen.width / 2 - 30, 100, 60, 30), "Retry?")) 
		{
		Application.LoadLevel(1);
				}
	}
}
