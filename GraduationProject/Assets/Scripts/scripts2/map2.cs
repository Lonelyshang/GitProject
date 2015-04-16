using UnityEngine;
using System.Collections;

public class map2 : MonoBehaviour
{
	public GameObject plane1;	
	public GameObject plane2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(plane1.transform.position.y<-72)
		{
			plane1.transform.position=new Vector3(0,plane2.transform.position.y+150,0);
		}
		if(plane2.transform.position.y<-70)
		{
			plane2.transform.position=new Vector3(0,plane1.transform.position.y+150,0);
		}
	}
}
