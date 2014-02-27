using UnityEngine;
using System.Collections;

public class FormationInvader : MonoBehaviour {

	FormationController _controller;

	void Start() {
		// find the formation controller
		_controller = transform.parent.gameObject.GetComponent<FormationController>();
	}

	// Update is called once per frame
	void Update () {
		float x = transform.position.x;

		if (x < _controller.leftEdge) {
			_controller.MoveRight();

		} else if (x > _controller.rightEdge) {
			_controller.MoveLeft();
		}
	}

//	void OnDestroyed() {
//		SendMessageUpwards("InvaderDestroyed");
//	}
}
