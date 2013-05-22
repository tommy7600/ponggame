using UnityEngine;
using System.Collections;

public class PlayerPaddleController : MonoBehaviour {
    private Ray ray;
	private Vector3 targetPoint;
	private float moveSpeed = 15.0f;
//	private float hitdist = 10.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		targetPoint = new Vector3(ray.origin.x, transform.position.y, transform.position.z);
		
		if(Input.GetMouseButton(0)){
				transform.position = Vector3.MoveTowards(transform.position, targetPoint, moveSpeed * Time.deltaTime);
		} else{
			Vector3 movement = new Vector3(Input.GetAxis("Horizontal") * moveSpeed,0,0);
			this.transform.Translate(movement * Time.deltaTime);
		}
	}
}
