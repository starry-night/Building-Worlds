using UnityEngine;
using System.Collections;

public class lightInteract : MonoBehaviour {
	

	void OnTriggerEnter(){
		this.light.enabled = !light.enabled;
		//Debug.Log ("light hit");
	}

}
