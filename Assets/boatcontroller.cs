﻿using UnityEngine;
using System.Collections;
[System.Serializable]
public class boatcontroller : MonoBehaviour {
	// Use this for initialization
	public float speed;
	public float tilt;
	void Start () {
	
	}

	void FixedUpdate () {
		 
				float moveHorizontal = Input.GetAxis ("Horizontal");
				float moveVertical = Input.GetAxis ("Vertical");
				print (moveHorizontal);
				print (moveVertical);
				Vector3 movement = new Vector3 (0.0f,moveVertical,0.0f);
				rigidbody.velocity = movement *speed;
		rigidbody.rotation = Quaternion.Euler (0.0f, 0.0f, rigidbody.velocity.y * tilt);
			


		}
}
