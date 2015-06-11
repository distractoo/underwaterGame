using UnityEngine;
using System.Collections;

public class sunRotation : MonoBehaviour
{
	public int obstacleSpeed;
	// Use this for initialization
	void Start ()
	{
		transform.Rotate (new Vector3 (0, 0, 10) * obstacleSpeed * Time.deltaTime);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
