//Light pulsing code adapted from BrigadeJosh at 
//http://answers.unity3d.com/questions/540496/red-pulsating-light-controllable-time.html

using UnityEngine;
using System.Collections;

public class tardisLight : MonoBehaviour {

	public float maxIntensity = 1f;
	public float minIntensity = 0f;
	public float pulseSpeed = 1f; //here, a value of 0.5f would take 2 seconds and a value of 2f would take half a second
	private float targetIntensity = 1f;
	private float currentIntensity; 

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (roomLight.robotActive == false) {
			//this.gameObject.transform.localScale = new Vector3 (1f, 1f, 1f)*(Mathf.PingPong(Time.time*0.07f,0.1f)+1f);
			currentIntensity = Mathf.MoveTowards(this.gameObject.light.intensity,targetIntensity, Time.deltaTime*pulseSpeed);
			if(currentIntensity >= maxIntensity){
				currentIntensity = maxIntensity;
				targetIntensity = minIntensity;
			}else if(currentIntensity <= minIntensity){
				currentIntensity = minIntensity;
				targetIntensity = maxIntensity;
			}
			this.gameObject.light.intensity = currentIntensity;
		}
		//Debug.Log (roomLight.robotActive);
	}
}
