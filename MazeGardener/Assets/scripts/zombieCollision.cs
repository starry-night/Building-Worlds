using UnityEngine;
using System.Collections;

public class zombieCollision : MonoBehaviour {

	public float maxCollision;
	float collisioncount=0; 

	void OnCollisionEnter(Collision Collection)
	{
		if(Collection.gameObject.tag == "peashooter" || Collection.gameObject.tag == "flower")
		{
			Destroy(Collection.gameObject);
			collisioncount ++;
			if(collisioncount > maxCollision) {
				Destroy (gameObject);
			}
		}

	}
}
