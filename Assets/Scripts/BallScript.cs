using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour {

	Rigidbody2D rb;
	public float impulso;
	int total_blocos;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		GameObject[] obj;
		obj = GameObject.FindGameObjectsWithTag("Bloco");
		total_blocos = obj.Length;
		print (total_blocos);
	}
	bool start;
	// Update is called once per frame
	void Update () {
		if (total_blocos == 0) {
			PlayerScript.inGame = false;
			SceneManager.LoadScene ("StartScene");
		}
		if (PlayerScript.inGame) {
			rb.GetComponent<CircleCollider2D> ().enabled = true;
			if (!start) {
				transform.SetParent(null);
				rb.isKinematic = false;
				rb.AddForce (new Vector2(impulso,impulso));
				start = true;
			}
		}
	}

	void OnCollisionEnter2D(Collision2D colider){
		if (colider.gameObject.tag == "Finish") {
			PlayerScript.inGame = false;
			SceneManager.LoadScene ("StartScene");
		}
		if (colider.gameObject.tag == "Bloco") {
			Destroy (colider.gameObject);
			total_blocos--;
		}

	}
}
