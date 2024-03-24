using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomgeneration : MonoBehaviour
{
	public GameObject cube;
	void Start()
	{
		Vector3 randomspawn= new Vector3(Random.Range(-10,11),0,Random.Range(-10,11));
		for(int i=1;i<=5;i++)
		{
		Instantiate(cube,randomspawn,Quaternion.identity);
		}
	}
}
