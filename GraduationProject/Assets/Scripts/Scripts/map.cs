using UnityEngine;
using System.Collections;

public class map : MonoBehaviour 
{

	public GameObject plane1;

	public GameObject plane2;

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{		
		if(plane1.transform.position.y<-120)
		{
			plane1.transform.position=new Vector3(0,plane2.transform.position.y+196,0);
		}
		if(plane2.transform.position.y<-120)
		{
			plane2.transform.position=new Vector3(0,plane1.transform.position.y+196,0);
		}
	}
}
