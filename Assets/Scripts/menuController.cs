using UnityEngine;
using System.Collections;

public class menuController : MonoBehaviour {
    private Ray ray;
	private RaycastHit hitPoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Input.GetMouseButton(0)){
			if(Physics.Raycast(ray, out hitPoint) && hitPoint.transform.name == "PlayButton"){
				Application.LoadLevel("mainGame");
			}
		}
	}
}
