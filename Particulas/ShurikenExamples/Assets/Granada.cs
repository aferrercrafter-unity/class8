using UnityEngine;

public class Granada : MonoBehaviour {

	public GameObject explPrefab;


	void OnCollisionEnter (Collision col) {

		Collider[] nearObjects = Physics.OverlapSphere(transform.position, 
												    	10f);

		for (int i = 0; i < nearObjects.Length; i++) {

			if (nearObjects [i].CompareTag ("Caja")) {
				nearObjects[i].SendMessage("Explotar", transform.position);
			}

		}

		Instantiate (explPrefab, transform.position, Quaternion.identity);

		Destroy (gameObject);

	}
}
