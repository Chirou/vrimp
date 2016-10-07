using UnityEngine;
using System.Collections;
using System.SceneManagement;

public class flappyinput : MonoBehaviour {

	public float jumpforce = 40f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		detectInput();

	
	}
	void detectInput(){
		if (Input.GetKey ("space")) {
			Debug.Log ("ButtonPressed");
			Jump ();
		}
	}

	void Jump(){
		gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (0f, 0f, 0f);
		gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0f,jumpforce,0f));
			
			}
	void OnCollisionEnter(){
		Debug.Log ("wat");
		SceneManager.LoadScene (0);
	}
	//instanciate
	//mathf.random
			//JetBrains
}
