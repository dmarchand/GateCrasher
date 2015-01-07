using UnityEngine;
using System.Collections;

public class FallingObjectController : MonoBehaviour {

	public float FallSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 newPosition = transform.position;
		newPosition.y -= FallSpeed * Time.deltaTime;
		transform.position = newPosition;
	}
}
