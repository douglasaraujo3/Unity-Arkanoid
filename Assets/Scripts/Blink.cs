using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blink : MonoBehaviour {

	public float intervalo;

	// Use this for initialization
	IEnumerator Start () {
		GetComponent<Text> ().enabled = false;
		yield return new WaitForSeconds (intervalo);
		GetComponent<Text> ().enabled = true;
		yield return new WaitForSeconds (intervalo);
		StartCoroutine (Start ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
