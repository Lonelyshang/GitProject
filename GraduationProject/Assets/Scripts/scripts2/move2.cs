using UnityEngine;
using System.Collections;

public class move2 : MonoBehaviour {

	private int speed=30;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector3.down*Time.deltaTime*speed,Space.World);
	}
}
