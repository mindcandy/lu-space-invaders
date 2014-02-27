using UnityEngine;
using System.Collections;

public class InputFiresShot : MonoBehaviour {

	public GameObject shot;
	public GameObject firingPoint;

	// fire cooldown timer
	public float fireCooldownTime = 1.0f;
	float _fireCooldown = 0.0f;

	// Update is called once per frame
	void Update () {
		if (_fireCooldown > 0.0f) {
			_fireCooldown -= Time.deltaTime;
		} else if (Input.GetButton("Fire1")) {
			Fire();
		}
	}

	void Fire() {
		Instantiate(shot, firingPoint.transform.position, Quaternion.identity);
		_fireCooldown = fireCooldownTime;
	}
}
