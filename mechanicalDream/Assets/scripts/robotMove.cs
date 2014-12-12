using UnityEngine;
using System.Collections;

public class robotMove : MonoBehaviour {

	public float moveSpeed = 500f;
	public float strength=1f;
	
	// Update is called once per frame
	void Update () {
		if (roomLight.robotActive==true){
		// apply a physics force to this object's rigidbody to make it "walk"
		rigidbody.AddForce ( transform.forward * Time.deltaTime * moveSpeed );
		// shoot a raycast 4 meters in front of me; if it hits something, then
		// I should randomly turn left or right
		if (Physics.Raycast ( transform.position, transform.forward, 3f ) ) {
			// Mathf.Sign returns -1 or 1 based on whether the number is negative or not
			transform.Rotate (0f, Mathf.Sign ( Random.Range (-1f, 1f) ) * 90f, 0f );
			//transform.Rotate (0f, Mathf.Sign ( 1f) * 90f, 0f );
		}
		// visualize raycast in debug mode (scene view)
		//Debug.DrawRay ( transform.position, transform.forward * 4f, Color.cyan );
		}
		else{
			rigidbody.velocity =Vector3.Lerp ( rigidbody.velocity,Vector3.zero,3f);
			//strength=Mathf.Clamp (strength-Time.deltaTime,0f,1f);
		}
	}
}
