using UnityEngine;
using System.Collections;

public class rivermoving : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		renderer.material.mainTextureOffset = new Vector2(Time.time * speed,0f);
	}
}
