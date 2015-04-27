using UnityEngine;
using System.Collections;

public class rockscript : MonoBehaviour {

	void onTriggerEnter(Collider other)
	{
		if (other.tag == "boundary")
						return;

		Destroy (other.gameObject);
		Destroy (gameObject);
	}
}
