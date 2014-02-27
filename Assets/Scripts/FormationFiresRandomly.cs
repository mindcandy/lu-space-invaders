using UnityEngine;
using System.Collections;

public class FormationFiresRandomly : MonoBehaviour {

	public GameObject shot;
	
	public float fireCooldownTimeMax = 2.0f;
	public float fireCooldownTimeMin = 0.5f;
	
	float _fireCooldown = 0.0f;

	// Use this for initialization
	void Start () {		
		WaitToFire();	
	}
	
	// Update is called once per frame
	void Update () {		
		_fireCooldown -= Time.deltaTime;
		if (_fireCooldown < 0.0f) {
			Fire();
			WaitToFire();
		}	
	}
		
	void WaitToFire() {
		_fireCooldown = Random.Range(fireCooldownTimeMin, fireCooldownTimeMax);
	}
	
	void Fire() {
		var invader = RandomInvader();
		if (invader != null) {
			Instantiate(shot, invader.position, Quaternion.identity);
		}
	}
		
	Transform RandomInvader() {
		var allInvaders = gameObject.GetComponentsInChildren<Transform>();
		if (allInvaders.Length == 0) {
			return null;
		} else {
			return allInvaders[Random.Range(0, allInvaders.Length-1)];
		}
	}

}
