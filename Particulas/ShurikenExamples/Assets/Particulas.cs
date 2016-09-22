using UnityEngine;

public class Particulas : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		GetComponent<ParticleSystem> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnParticleCollision(GameObject other)
	{
		
	}

	void OnParticleTrigger()
	{
	}
}
