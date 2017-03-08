using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	private bool facingRight = true;
	// Update is called once per frame
	void Update () {
		var x = Input.GetAxis("Horizontal");
		if (x < 0 && facingRight || x >= 0 && !facingRight) {
			transform.Rotate(Vector3.up * 180);
			facingRight = !facingRight;
		}

		transform.Translate(Vector3.right * x * speed * Time.deltaTime, Space.World);
	}
}
