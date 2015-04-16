using UnityEngine;
using System.Collections;

public class stonefell : MonoBehaviour 
{
	public GameObject gobj_boom;//粒子

	private int speed=10;
	
	// Use this for initialization
	void Start () 
	{

	}
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate(new Vector3(-1, 0, 0)* 20*Time.deltaTime);
		transform.Translate(Vector3.down * Time.deltaTime*speed, Space.World);  
		if(transform.position.y<35f)
		{
			ui.missed++;
			ui.bloods-=5;
			Destroy(transform.gameObject);
		}
	}
}
