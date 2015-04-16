using UnityEngine;
using System.Collections;

public class Lasershoot : MonoBehaviour 
{
	private int speed = 100;
	public GameObject gobj_boom;//粒子

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position=new Vector3(planFly2.planeX,transform.position.y,transform.position.z);
		transform.Translate(Vector3.up* Time.deltaTime * speed,Space.World);
	}

	void OnCollisionEnter2D(Collision2D coll) 
	{
		if(coll.gameObject.tag!="Player"&&coll.gameObject.tag!="Laser")
		{
			Destroy(Instantiate(gobj_boom,coll.transform.position,new Quaternion(0,0,0,0)),1);//实例后销毁粒子效果			
			if(coll.gameObject.tag=="stones")
			{
				ui.score+=100;
			}
			Destroy(coll.gameObject);
			Destroy(transform.gameObject);
		}
	}
}
