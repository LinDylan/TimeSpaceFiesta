using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Gravity : MonoBehaviour {
	Rigidbody2D rb2d = null;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (rb2d.velocity.y < 0) {
			rb2d.velocity += Vector2.up * Physics2D.gravity.y * (2.5f - 1) * Time.deltaTime;
		} else if (rb2d.velocity.y > 0 && !Input.GetKeyDown(KeyCode.Space)) {
			rb2d.velocity += Vector2.up * Physics2D.gravity.y * (4 - 1) * Time.deltaTime;
		}
	}
}
