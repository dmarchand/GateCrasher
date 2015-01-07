using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


	public delegate void OnKillDelegate();
	public event OnKillDelegate OnKill;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Kill() {
		if(OnKill != null) {
			OnKill();
		}
	}
}
