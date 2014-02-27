using UnityEngine;
using System.Collections;

public class InputMoveLR : MonoBehaviour {

	public float speed = 10.0f;
	public float minX = -5.0f;
	public float maxX = 5.0f;

	// Update is called once per frame
	void Update () {
		float delta = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		
		transform.position += new Vector3(delta, 0.0f);
		
		if (transform.position.x < minX) {
			transform.position = new Vector3(minX, transform.position.y, transform.position.z);
		} else if (transform.position.x > maxX) {
			transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
		}

	}
}
