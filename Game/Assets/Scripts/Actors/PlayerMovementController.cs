using UnityEngine;
using System.Collections;

public class PlayerMovementController : MonoBehaviour {

    private float _timeSinceLastMove = 0;

    [HideInInspector]
    public Vector3 Position;

    public float MoveSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        HandleInputs();
	}

    void HandleInputs()
    {


        if (Input.GetButton("Horizontal"))
        {
            float h = Input.GetAxis("Horizontal");
            int direction = h < 0 ? -1 : 1;
            float currentSpeed = MoveSpeed * direction * Time.deltaTime;
            MoveHorizontal(transform.position.x + currentSpeed );
        }
        else if (Input.GetButton("Fire1"))
        {
            var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            int direction = mousePos.x < 0 ? -1 : 1;
            MoveHorizontal(mousePos.x);
        }

    }

    void MoveHorizontal(float xPos)
    {
        Vector3 newPosition = new Vector3();
        newPosition.Set(xPos, transform.position.y, transform.position.z);
        transform.position = newPosition;
        _timeSinceLastMove = 0;
    }
}
