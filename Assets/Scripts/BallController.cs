using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < -5){
			Application.LoadLevel("menuGame");
		}
	}
	
	void Awake(){
		rigidbody.AddForce(6,6,0,ForceMode.Impulse);
		InvokeRepeating("IncreaseBallVelocity", 30, 30);
	}
	
	void IncreaseBallVelocity(){
		rigidbody.velocity = rigidbody.velocity + rigidbody.velocity.normalized * 2 * Time.deltaTime;
		Debug.Log (rigidbody.velocity);
	}
}
