using UnityEngine;
using System.Collections;

public class Caja : MonoBehaviour {

	private Rigidbody rb;

	void Awake ()
	{
		rb = GetComponent<Rigidbody> ();
	}

	public void Explotar(Vector3 posDeExplosion) {

		rb.AddExplosionForce (250.0f, posDeExplosion, 10f);

	}

}
