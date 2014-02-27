using UnityEngine;
using System.Collections;

public class FormationController : MonoBehaviour {

	public float leftEdge = -5.5f;
	public float rightEdge = 5.5f;

	public float speedX = 0.3f;
	public float speedY = 0.3f;

	public float stepTime = 0.5f;
	public float minStepTime = 0.05f;
	public float stepTimeReduction = 0.9f;
	
	float _sinceLastStep = 0.0f;
	bool _directionLeft = false;
	bool _moveDown = false;

	// Use this for initialization
	void Start () {
		_sinceLastStep = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		float deltaY = 0.0f;
		float deltaX = 0.0f;

		_sinceLastStep += Time.deltaTime;
		if (_sinceLastStep > stepTime) {
			_sinceLastStep -= stepTime;

			// move down
			if (_moveDown) {
				_moveDown = false;
				stepTime = Mathf.Max(stepTime * stepTimeReduction, minStepTime);
				deltaY = -speedY;
			}

			// take a step left or right
			if (_directionLeft) {
				deltaX = -speedX;
			} else {
				deltaX = speedX;
			}
		}

		transform.position += new Vector3(deltaX, deltaY);	
	}
	
	public void MoveLeft () {
		_directionLeft = true;
		_moveDown = true;
	}

	public void MoveRight() {
		_directionLeft = false;
		_moveDown = true;
	}

}
