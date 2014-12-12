using UnityEngine;
using System.Collections;

public class happy : MonoBehaviour {
	
	public Transform happyBlueprint1;
	public Transform happyBlueprint2;
	public Transform happyBlueprint3;

	public int maxCopies1;
	public int maxCopies2;
	public int maxCopies3;

	public int min,max;
	int randomPosX;
	int randomPosZ;
	int randomPos3X;
	int randomPos3Z;

	public GameObject floor;
	public Material happyTex;	
	public Material happySky;
	public GameObject par;
	
	// Use this for initialization
	void Start () {
		StartCoroutine (Generator1 ());
		StartCoroutine (Generator2 ());
		StartCoroutine (Generator3 ());
		RenderSettings.skybox=happySky;
		floor.renderer.material = happyTex;
		RenderSettings.ambientLight = new Color(0.556f, 0.549f, 0.396f,0.03f);
		par.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {

		//floor.renderer.material= happyTex;
		randomPosX = Random.Range (-50, 35);
		if (randomPosX > -10) {
			randomPosX+=15;
		}
		randomPosZ = Random.Range (-50, 35);
		if (randomPosZ > -10) {
			randomPosZ+=15;
		}
		randomPos3X = Random.Range (-50, 35);
		if (randomPos3X > -10) {
			randomPos3X+=15;
		}
		randomPos3Z = Random.Range (-50, 35);
		if (randomPos3Z > -10) {
			randomPos3Z+=15;
		}
		
	}
	
	IEnumerator Generator1(){
		yield return new WaitForSeconds (3.5f); 
		
		int counter1 = 0;
		
		while (counter1 < maxCopies1) {
			
			Instantiate (happyBlueprint1, randomPosition1 (), Quaternion.Euler (0, Random.Range (0, 360), 0));
			
			counter1++;
			yield return new WaitForSeconds (0.25f); 
			
		}
		
		
		
	}
	IEnumerator Generator2(){
		yield return new WaitForSeconds (3.5f); 
		
		int counter2 = 0;
		
		while (counter2 < maxCopies2) {
			
			Instantiate (happyBlueprint2, randomPosition2 (), Quaternion.Euler (0, Random.Range (0, 180), 0));
			
			counter2++;
			yield return new WaitForSeconds (0.25f); 
			
		}
	}
	IEnumerator Generator3(){
		yield return new WaitForSeconds (3.5f); 
		
		int counter3 = 0;
		
		while (counter3 < maxCopies3) {
			
			Instantiate (happyBlueprint3, randomPosition3 (), Quaternion.Euler (0, Random.Range (0, 360), 0));
			
			counter3++;
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
	/*Vector3 randomPosition1()
	{
		int x,y,z;
		x = randomPosX;
		y = UnityEngine.Random.Range (0, 0);
		z = randomPosZ;
		return new Vector3(x,y,z);
	}*/
	Vector3 randomPosition2()
	{
		int x,y,z;
		x = randomPosX;
		y = UnityEngine.Random.Range (0, 0);
		z = randomPosZ;
		return new Vector3(x,y,z);
	}
	Vector3 randomPosition3()
	{
		int x,y,z;
		x = randomPos3X;
		y = UnityEngine.Random.Range (0, 0);
		z = randomPos3Z;
		return new Vector3(x,y,z);
	}
}
