using UnityEngine;
using System.Collections;

public class ExplodesWhenDestroyed : MonoBehaviour {

	public GameObject explosion;
		
	void OnDestroyed() {
		Instantiate(explosion, transform.position, Quaternion.identity);
	}
}
