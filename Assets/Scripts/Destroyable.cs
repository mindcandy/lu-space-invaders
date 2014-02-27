using UnityEngine;
using System.Collections;

public class Destroyable : MonoBehaviour {

	public float toughness = 1.0f;
	float health;

	void Start () {
		health = toughness;
	}

	void OnCollisionEnter2D(Collision2D coll) {
		Destroy(coll.gameObject);

		health -= 1.0f;
		
		if (health <= 0.0f) {
			// send message saying this is destroyed
			SendMessage("OnDestroyed", SendMessageOptions.DontRequireReceiver);
			Destroy(this.gameObject);
		} else {
			// send a message saying how damaged this object is (1= no damage, 0= dead)
			SendMessage("OnDamaged", health/toughness, SendMessageOptions.DontRequireReceiver);
		}
	}

}

