using UnityEngine;
using System.Collections;

public class boundaryscript : MonoBehaviour {
	void OnTriggerExit(Collider other) {
		Destroy(other.gameObject);
	}
}
