using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour {

	public float speed = 3.0f;
	
	// Update is called once per frame
	void FixedUpdate () {
		rigidbody2D.velocity = new Vector2(0.0f, speed);

	}
}
