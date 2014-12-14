using UnityEngine;
using System.Collections;

public class angry : MonoBehaviour {
	
	public Transform angryBlueprint1;
	public Transform angryBlueprint2;
	public Transform angryBlueprint3;

	public int maxCopies1;
	public int maxCopies2;
	public int maxCopies3;
	
	public int min,max;
	int randomPosX;
	int randomPosZ;
	int randomPos3X;
	int randomPos3Z;

	public Material angryTex;
	public Material angrySky;
	public GameObject floor;

	public GameObject angrySound;
	public GameObject backgroundSound;
	public GameObject tardisSound;
	
	// Use this for initialization
	void Start () {
		StartCoroutine (Generator1 ());
		StartCoroutine (Generator2 ());
		StartCoroutine (Generator3 ());

		floor.renderer.material = angryTex;
		RenderSettings.skybox=angrySky;
		RenderSettings.ambientLight = new Color(0.714f, 0.239f, 0.063f,0.03f);

		angrySound.SetActive(true);
		backgroundSound.SetActive(false);
		tardisSound.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
		//floor.renderer.material= happyTex;
		randomPosX = Random.Range (-200, 150);
		if (randomPosX > -50) {
			randomPosX+=100;
		}
		randomPosZ = Random.Range (-200, 150);
		if (randomPosZ > -50) {
			randomPosZ+=100;
		}
		randomPos3X = Random.Range (-50, 45);
		if (randomPos3X > -5) {
			randomPos3X+=10;
		}
		randomPos3Z = Random.Range (-50, 45);
		if (randomPos3Z > -5) {
			randomPos3Z+=10;
		}
		
	}
	
	IEnumerator Generator1(){
		yield return new WaitForSeconds (3.5f); 
		
		int counter1 = 0;
		
		while (counter1 < maxCopies1) {
			
			Instantiate (angryBlueprint1, randomPosition1 (), Quaternion.Euler (0, Random.Range (0, 360), 0));
			
			counter1++;
			yield return new WaitForSeconds (0.25f); 
			
		}
		
		
		
	}
	IEnumerator Generator2(){
		yield return new WaitForSeconds (3.5f); 
		
		int counter2 = 0;
		
		while (counter2 < maxCopies2) {
			
			Instantiate (angryBlueprint2, randomPosition2 (), Quaternion.Euler (0, Random.Range (0, 180), 0));
			
			counter2++;
			yield return new WaitForSeconds (0.25f); 
			
		}
	}
	IEnumerator Generator3(){
		yield return new WaitForSeconds (3.5f); 
		
		int counter3 = 0;
		
		while (counter3 < maxCopies3) {
			
			Instantiate (angryBlueprint3, randomPosition3 (), Quaternion.Euler (0, Random.Range (0, 360), 0));
			
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