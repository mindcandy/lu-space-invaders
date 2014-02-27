using UnityEngine;
using System.Collections;

public class FormationDeadWhenEmpty : MonoBehaviour {

	int _invadersRemaining;
	
	// Use this for initialization
	void Start () {
		_invadersRemaining = gameObject.GetComponentsInChildren<FormationInvader>().Length;	
	}
	
	void InvaderDestroyed() {
		_invadersRemaining--;
		if (_invadersRemaining == 0) {
			// all killed, respawn!
			Destroy(gameObject);
		}
	}
}
