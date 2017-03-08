using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeremyGenerator : MonoBehaviour {

	public float speed;
	public GameObject jeremyExplosive;
	void Start () {
		InvokeRepeating("GenerateJeremy", speed, speed);
	}

	void GenerateJeremy() {
		Instantiate(jeremyExplosive, transform.position, jeremyExplosive.transform.rotation);
		transform.Translate(Vector3.right * 5);
	}
}
