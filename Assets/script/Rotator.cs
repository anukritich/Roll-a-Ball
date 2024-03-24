using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotator : MonoBehaviour {

	// As we now know, Update is called once per frame
	void Update ()
	{
		transform.Rotate( new Vector3(15, 30, 45) * Time.deltaTime);
	}
}
