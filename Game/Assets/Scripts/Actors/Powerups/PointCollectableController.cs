using UnityEngine;
using System.Collections;

public class PointCollectableController : MonoBehaviour {

	public int Points;

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
			player.AddScore(Points);
			ObjectPool.Recycle(this);
		}
	}
}
