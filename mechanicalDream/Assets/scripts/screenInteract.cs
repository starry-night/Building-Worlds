using UnityEngine;
using System.Collections;

public class screenInteract : MonoBehaviour {

	public GameObject screen;

	void OnTriggerEnter(){
		//screen.SetActive(false);
		screen.renderer.enabled = !renderer.enabled;
		//Debug.Log ("hit");
	}

}
