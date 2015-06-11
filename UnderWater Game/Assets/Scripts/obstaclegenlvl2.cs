using UnityEngine;
using System.Collections;

public class obstaclegenlvl2 : MonoBehaviour
{

		
	public GameObject[] obstacles;
		
	//i am declaring a variable Opos which i will use to show the Obstacle Position
	float Opos;
		
	IEnumerator generateObstacles ()
	{
			
		while (true) {
				
			//i am generating obstacles from an x of -7 to 7
			Opos = Random.Range (-7f, 7f);
				
			//choosing one random obstacle  from 3
			int obstacleChooser = (int)Mathf.Floor (Random.Range (0f, 3f));
				
				
			Debug.Log (obstacleChooser);
				
			//i am instantiating the obstacles using the opos -7 to 7 and y and z co-ordinates given below.		
			Instantiate (obstacles [obstacleChooser], new Vector3 (Opos, 5, 4), Quaternion.identity);			
				
				
			yield return new WaitForSeconds (1f);
		}
	}
		
	void Start ()
	{
			
		StartCoroutine ("generateObstacles");
	}
		
	void Update ()
	{
			
	}
}
