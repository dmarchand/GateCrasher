using UnityEngine;
using System.Collections;

public class PlayerCollisionController : MonoBehaviour {



    void OnTriggerEnter2D(Collider2D other)
    {
        var playerKiller = other.GetComponent<PlayerKillerController>();

        if (playerKiller != null)
        {
			GetComponent<PlayerController>().Kill();
        }
    }
}
