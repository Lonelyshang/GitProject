using UnityEngine;
using System.Collections;

public class map_move : MonoBehaviour {

	public int speed=5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.down*Time.deltaTime*speed,Space.World);
	}
}
