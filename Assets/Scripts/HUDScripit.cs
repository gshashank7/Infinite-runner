using UnityEngine;
using System.Collections;

public class HUDScripit : MonoBehaviour {

	float playerScore = 0;
	int coins = 0;
	
	// Update is called once per frame
	void Update () {
	
		playerScore += Time.deltaTime;
	}
	

	public void IncreaseCoins(int CoinAmount)
	{
		coins += 1;
		}
	void OnDisable()
	{
		PlayerPrefs.SetInt ("Score", (int)(playerScore/2));
		PlayerPrefs.SetInt("Coins", (int)(coins));

	}
	void OnGUI()
	{
		GUI.Label (new Rect (10, 10, 100, 30), "distance: " +(int)(playerScore/2));
		GUI.Label (new Rect (10, 20, 100, 30), "coins: " +(int)(coins));
	}
}
