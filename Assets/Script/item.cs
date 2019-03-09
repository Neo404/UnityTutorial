using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter (Collider hit) {
		if (hit.CompareTag("Player")) {
			Destroy(gameObject);
		}
	}
}
