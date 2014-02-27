using UnityEngine;
using System.Collections;

//
// visaulise damage as sprites
//
public class SpriteDamage : MonoBehaviour {

	// array of sprites to show at different health levels
	// first is most damaged, last is 100% healthy
	public Sprite[] damageSprites;

 	SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

	// sprite is damaged
	void OnDamaged(float normalisedHealth) {
		int spriteIndex = Mathf.FloorToInt(normalisedHealth * (damageSprites.Length - 0.01f));
		spriteRenderer.sprite = damageSprites[spriteIndex];
	}

}
