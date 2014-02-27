using UnityEngine;
using System.Collections;

// Explosion behaviour - remove itself after a second
public class Explosion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy(gameObject, 1.0f);
	}

}
