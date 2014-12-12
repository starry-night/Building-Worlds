using UnityEngine;
using System.Collections;

public class instantiateEnabler : MonoBehaviour {
	int roll;

	// Use this for initialization
	void Start () {
		roll = Random.Range (1, 100);
		//Debug.Log (roll);
	}
	
	// Update is called once per frame
	void Update () {

		if (roomLight.robotActive==false&&roll<=35){
			GetComponent<sad>().enabled=true;
		}
		else if (roomLight.robotActive==false&&roll>35&&roll<=70){
			GetComponent<happy>().enabled=true;
		}
		else if (roomLight.robotActive==false&&roll>70&&roll<101){
			GetComponent<angry>().enabled=true;
		}
	}

}
