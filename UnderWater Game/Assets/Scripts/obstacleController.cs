using UnityEngine;
using System.Collections;

public class obstacleController : MonoBehaviour
{

	public int obstacleSpeed;

	void Start ()
	{
		
	}

	void Update ()
	{

		
		
		//Here i am rotating the object
		transform.Rotate (new Vector3 (0, 0, 10) * obstacleSpeed * Time.deltaTime);
		
		///move the refuse along the y axis to the bottom
		if (transform.position.y > -5) {

			transform.Translate (new Vector3 (0, -1, 0) * obstacleSpeed * Time.deltaTime, Space.World);
		}
		
		
	}
}