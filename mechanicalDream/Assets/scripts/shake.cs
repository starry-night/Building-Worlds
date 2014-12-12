using UnityEngine;
using System.Collections;

public class shake : MonoBehaviour {
	public float distance=0.2f;
	public float speed=50f;
	
	float shakeStrength=1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.z > 14f) {
			Camera.main.transform.position += new Vector3 (Mathf.Sin (Time.time * speed) * distance*shakeStrength, 0f, 0f);
			shakeStrength=Mathf.Clamp (shakeStrength-Time.deltaTime,0f,1f);
		}
	}
}
