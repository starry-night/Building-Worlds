//rain prefab from http://www.unityninja.net/t33-free-rain-particle-system
using UnityEngine;
using System.Collections;

public class afraid : MonoBehaviour {

	public Transform afraidBlueprint1;
	public Transform afraidBlueprint2;
	public int maxCopies1;
	public int maxCopies2;
	public int min,max;
	int randomPosX;
	int randomPosZ;
	
	public Material afraidSky;
	public GameObject rain;
	
	public GameObject afraidSound;
	public GameObject backgroundSound;
	public GameObject tardisSound;
	
	// Use this for initialization
	void Start () {
		StartCoroutine (Generator1 ());
		StartCoroutine (Generator2 ());
		RenderSettings.skybox=afraidSky;
		RenderSettings.ambientLight = new Color(0.015f, 0.129f, 0.211f,0.03f);
		rain.SetActive(true);
		afraidSound.SetActive(true);
		backgroundSound.SetActive(false);
		tardisSound.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		randomPosX = Random.Range (-50, 45);
		if (randomPosX > -5) {
			randomPosX+=10;
		}
		randomPosZ = Random.Range (-50, 45);
		if (randomPosZ > -5) {
			randomPosZ+=10;
		}
		
	}
	
	IEnumerator Generator1(){
		yield return new WaitForSeconds (3.5f); 
		
		int counter1 = 0;
		
		while (counter1 < maxCopies1) {
			
			Instantiate (afraidBlueprint1, randomPosition1 (), Quaternion.Euler (0, Random.Range (0, 360), 0));
			
			counter1++;
			yield return new WaitForSeconds (0.25f); 
			
		}
		
		
		
	}
	IEnumerator Generator2(){
		yield return new WaitForSeconds (3.5f); 
		
		int counter2 = 0;
		
		while (counter2 < maxCopies2) {
			
			Instantiate (afraidBlueprint2, randomPosition2 (), Quaternion.Euler (0, Random.Range (0, 360), 0));
			
			counter2++;
			yield return new WaitForSeconds (0.25f); 
			
		}
	}
	Vector3 randomPosition1()
	{
		int x,y,z;
		x = UnityEngine.Random.Range(min,max);
		y = UnityEngine.Random.Range (3, 30);
		z = UnityEngine.Random.Range(min,max);
		return new Vector3(x,y,z);
	}
	Vector3 randomPosition2()
	{
		int x,y,z;
		x = randomPosX;
		y = UnityEngine.Random.Range (0, 0);
		z = randomPosZ;
		return new Vector3(x,y,z);
	}
}
