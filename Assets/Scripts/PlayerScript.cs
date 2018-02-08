using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	public float velocidade;
	// Use this for initialization
	void Start () {
	}
	public static bool inGame;
	// Update is called once per frame
	void Update () {
		float move_x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * velocidade;
		transform.Translate(move_x,0.0f,0.0f);
		if (Input.GetButtonDown ("Jump") && !inGame) {
			inGame = true;
		}

	}
}
