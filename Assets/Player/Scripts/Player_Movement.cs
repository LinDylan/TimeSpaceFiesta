using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {
	float speed = 5.0f;
	Rigidbody2D rb2d = null;
	bool jumping;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		jumping = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.A)) {
			rb2d.velocity = new Vector2 (-1 * 100 * speed * Time.deltaTime, rb2d.velocity.y);
		}
		if (Input.GetKey (KeyCode.D)) {
			rb2d.velocity = new Vector2 (1 * 100 * speed * Time.deltaTime, rb2d.velocity.y);
		}
		if (Input.GetKeyUp (KeyCode.D) || Input.GetKeyUp (KeyCode.A)) {
			rb2d.velocity = new Vector2 (0, rb2d.velocity.y);
		}
		if (Input.GetKeyDown(KeyCode.Space) && !jumping) {
			rb2d.velocity = new Vector2(rb2d.velocity.x, 17.5f);
			jumping = true;
		}
	}

	void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.tag == "Land") {
			jumping = false;
		}
	}
}
