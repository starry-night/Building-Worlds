using UnityEngine;
using System.Collections;

public class tankSpawn : MonoBehaviour {
	
		public Transform tankBlueprint;
		public int maxCopies;
		public int min, max;
		
		
		void Start(){
			StartCoroutine (Generator () );
		}
		
		IEnumerator Generator(){
			
			int counter = 0;
			
			while (counter < maxCopies) {
				
			Instantiate(tankBlueprint, randomPosition(), Quaternion.Euler(0, Random.Range(0, 180), 0));
				
				counter++;
				yield return new WaitForSeconds(0.5f); 
				
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