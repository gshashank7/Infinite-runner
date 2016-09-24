using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {

	int coins = 0;

	HUDScripit hud;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
						hud = GameObject.Find ("Main Camera").GetComponent<HUDScripit> ();
						hud.IncreaseCoins (1);
						Destroy (this.gameObject);

				}	
				

	}

}
