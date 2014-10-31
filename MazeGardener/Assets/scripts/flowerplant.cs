using UnityEngine;
using System.Collections;

public class flowerplant : MonoBehaviour {
	
	public Transform peashooter;
	public Transform flower;
	public float plantInterval;


	float nextPlantingTime=0f;

	// Use this for initialization
	void Start () {
		nextPlantingTime=Time.time+plantInterval;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextPlantingTime ) {
			if (Random.Range (0f, 1f) > 0.4f ) {
				Instantiate ( peashooter, transform.position, Quaternion.identity );
				nextPlantingTime += Random.Range( plantInterval, plantInterval+5f);
			}
			else {
				Instantiate ( flower, transform.position, Quaternion.identity );
				nextPlantingTime += Random.Range( plantInterval, plantInterval+5f);
			}

		}
	}
}
