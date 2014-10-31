using UnityEngine;
using System.Collections;

public class zombiespawn : MonoBehaviour {

	public Transform zombie;
	public Transform smallZombie;
	public float zombieInterval;
	
	float nextPlantingTime=0f;
	
	// Use this for initialization
	void Start () {
		nextPlantingTime=Time.time+zombieInterval;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextPlantingTime ) {
			if (Random.Range (0f, 1f) > 0.3f ) {
			Instantiate ( zombie, transform.position, Quaternion.identity );
			nextPlantingTime += Random.Range( zombieInterval, zombieInterval+5f);
			}
			else {
			nextPlantingTime += Random.Range( zombieInterval, zombieInterval+5f);
			}
		}
	}
}