using UnityEngine;
using System.Collections;

public class empireSpawn : MonoBehaviour {
	public Transform empireBlueprint;
	public Transform kongBlueprint;
	public int maxCopies;
	public int min, max;
	

	void Start(){
		StartCoroutine (Generator () );
	}

	IEnumerator Generator(){

		int counter = 0;
		
		float randomNumber;

		
		while (counter < maxCopies) {
			
			randomNumber =Random.Range (0,10f);

			if (randomNumber<3f){
				Instantiate(kongBlueprint, randomPosition(), Quaternion.identity);
			}

			else {
				Instantiate(empireBlueprint, randomPosition(), Quaternion.identity);
			}

			counter++;
			yield return new WaitForSeconds(1f); 
			
		}
	}

	Vector3 randomPosition()
	{
		int x,y,z;
		x = UnityEngine.Random.Range(min,max);
		y = 0;
		z = UnityEngine.Random.Range(min,max);
		return new Vector3(x,y,z);
	}
	
	
	
}