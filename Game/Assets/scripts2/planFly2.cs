﻿using UnityEngine;
using System.Collections;

public class planFly2 : MonoBehaviour 
{
	public static int  speed = 40;
	public GameObject airplne; 

	public GameObject stone;
	public GameObject  gobj_boom;

	public static float planeX;

	// Use this for initialization
	void Start () 
	{	
	}
	
	// Update is called once per frame
	void Update () 
	{
//     	Debug.Log (airplne.transform.position);
		if(((Input.GetKey(KeyCode.W)||(Input.GetKey(KeyCode.UpArrow)))&&airplne.transform.position.y<95))
		{
			airplne.transform.Translate(Vector3.up* Time.deltaTime * speed,Space.World);
		}
		if((Input.GetKey(KeyCode.D)||(Input.GetKey(KeyCode.RightArrow)))&&airplne.transform.position.x<38)
		{
			airplne.transform.Translate(Vector3.right* Time.deltaTime * speed,Space.World);
			planeX=airplne.transform.position.x;
		}
		if((Input.GetKey(KeyCode.A)||(Input.GetKey(KeyCode.LeftArrow)))&&airplne.transform.position.x>-37)
		{
			airplne.transform.Translate(Vector3.left* Time.deltaTime * speed,Space.World);
			planeX=airplne.transform.position.x;
		}
		if((Input.GetKey(KeyCode.S)||(Input.GetKey(KeyCode.DownArrow)))&&airplne.transform.position.y>47)
		{
			airplne.transform.Translate(Vector3.down* Time.deltaTime * speed,Space.World);
		}
		if(ui.signal)
		{
			airplne.transform.Translate(Vector3.up*1,Space.World);
		}
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if(coll.transform.tag!="Player"&&coll.gameObject.tag!="Laser")
		{
			GameObject tm_boom = Instantiate(gobj_boom,coll.transform.position,new Quaternion()) as GameObject;
			Destroy(tm_boom,2);			
			Destroy(coll.transform.gameObject);
			ui.bloods-=5;
		}
	}
}