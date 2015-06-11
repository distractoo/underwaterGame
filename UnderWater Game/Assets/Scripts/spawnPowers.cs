using UnityEngine;
using System.Collections;

public class spawnPowers : MonoBehaviour
{
	public GameObject[] powerups;
	
	//i am declaring a variable Opos which i will use to show the Obstacle Position
	float pups;
	
	IEnumerator spawnpups ()
	{
		
		while (true) {
			
			//i am generating obstacles from an x of -7 to 7
			pups = Random.Range (-7f, 7f);
			
			//choosing one random obstacle  from 3
			int pupsChooser = (int)Mathf.Floor (Random.Range (0f, 2f));
						
			Debug.Log (pupsChooser);
			

			Instantiate (powerups [pupsChooser], new Vector3 (pups, 5, 4), Quaternion.identity);			
			
			//spawn a Powerup every 10 seconds
			yield return new WaitForSeconds (10f);
		}
	}
	
	void Start ()
	{
		
		StartCoroutine ("spawnpups");
	}
	
	void Update ()
	{
		

	}
}