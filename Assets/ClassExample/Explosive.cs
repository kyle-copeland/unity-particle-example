using UnityEngine;

public class Explosive : MonoBehaviour {

	public ParticleSystem wick;
	public ParticleSystem explosion;
	public PerlinShake shake;

	void Update () {
		if (!wick.IsAlive() && !explosion.isPlaying) {
			explosion.Play();
			shake.PlayShake();
			this.gameObject.GetComponent<MeshRenderer>().enabled = false;
			Destroy(this.gameObject, explosion.main.duration);
		}
	}
}
