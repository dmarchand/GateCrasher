using UnityEngine;
using System.Collections;


public class MultiplierUpController : MonoBehaviour {

	public float MultiplierBonus;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		var player = other.GetComponent<PlayerModel>();
		
		if (player != null)
		{
			player.CurrentMultiplier += MultiplierBonus;
			ObjectPool.Recycle(this);
		}
	}
}
