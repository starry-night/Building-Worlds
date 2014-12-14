//Light pulsing code adapted from BrigadeJosh at 
//http://answers.unity3d.com/questions/540496/red-pulsating-light-controllable-time.html

using UnityEngine;
using System.Collections;



public class roomLight : MonoBehaviour {

	public static bool robotActive=true;

	public GameObject robot;

	private Vector3 screenPoint;	
	private Vector3 offset;
	
	public Texture2D altCursor;


	public Transform nWall;
	public Transform eWall;
	public Transform sWall;
	public Transform wWall;
	public Transform celling;

	public GameObject painting;
	public GameObject window;
	public GameObject frame;
	public GameObject frame2;
	public GameObject lightBase;

	private bool toggle=true;

	private Color colorStart;
	private Color colorEnd;

	public Texture2D lightOFF;

	float duration=1000f;
	float t;
	/*
	public float maxIntensity = 1f;
	public float minIntensity = 0f;
	public float pulseSpeed = 1f; //here, a value of 0.5f would take 2 seconds and a value of 2f would take half a second
	private float targetIntensity = 1f;
	private float currentIntensity; 
	*/

	void OnMouseEnter () {
		Cursor.SetCursor(altCursor, Vector2.zero, CursorMode.Auto);
	}
	
	void OnMouseExit () {
		Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);	
	}
	void Update(){
		if (toggle == true) {
			this.gameObject.transform.localScale = new Vector3 (1f, 1f, 1f)*(Mathf.PingPong(Time.time*0.07f,0.1f)+1f);
			this.gameObject.transform.position+=new Vector3 (0, 0.004f, 0) * Mathf.Sin (Time.time*2f);	
			/*currentIntensity = Mathf.MoveTowards(this.gameObject.light.intensity,targetIntensity, Time.deltaTime*pulseSpeed);
			if(currentIntensity >= maxIntensity){
				currentIntensity = maxIntensity;
				targetIntensity = minIntensity;
			}else if(currentIntensity <= minIntensity){
				currentIntensity = minIntensity;
				targetIntensity = maxIntensity;
			}
			this.gameObject.light.intensity = currentIntensity;*/
		}
	}
	
	void OnMouseDown()
	{
		this.gameObject.light.enabled = !light.enabled;


		if (toggle == true) {

			colorStart=celling.renderer.material.color;
			colorEnd=new Color(colorStart.r, colorStart.g, colorStart.b, 0);

			for (t = 0.0f; t < duration; t += Time.deltaTime) {
				celling.renderer.material.color = Color.Lerp (colorStart, colorEnd, t/duration);
			}

			eWall.rigidbody.isKinematic=false;
			nWall.rigidbody.isKinematic=false;
			wWall.rigidbody.isKinematic=false;

			painting.SetActive(false);
			window.SetActive(false);
			frame.SetActive(false);
			frame2.SetActive(false);
			lightBase.SetActive(false);

			this.gameObject.renderer.material.mainTexture=lightOFF;

			toggle=false;
			robotActive=false;


			//this.gameObject.light.intensity= 3;

		}
		else {
			//par.SetActive(false);

			//painting.SetActive(true);
			//window.SetActive(true);

			Application.LoadLevel(0);

			toggle=true;
			robotActive=true;
		}

		
	}
	

}
