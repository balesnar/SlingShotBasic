using UnityEngine;
using System.Collections;

public class Collide1 : MonoBehaviour

	{

	// Use this for initialization
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "trigger")
		{
			Destroy(col.gameObject);
	
	}
	
 
	
	}
}
