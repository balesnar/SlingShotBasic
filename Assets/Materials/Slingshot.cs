using UnityEngine;
using System.Collections;

public class Slingshot : MonoBehaviour {

	public GameObject launchPoint;


	void Awake() {
		Transform launchPointTrans = transform.Find("LaunchPoint");
		launchPoint = launchPointTrans.gameObject;
		launchPoint.SetActive(false);

}

		void OnMouseEnter() {
		print ("Yes, the mouse is here.");
		launchPoint.SetActive(true);
	}
		void OnMouseExit() {
		print ("Now the mouse has left.");
		launchPoint.SetActive(false);
	}
}


