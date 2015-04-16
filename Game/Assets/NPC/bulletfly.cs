using UnityEngine;
using System.Collections;

public class bulletfly : MonoBehaviour {
	//敌机子弹飞行

	private static float speed = 30;

//	GameObject zd;
	// Use this for initialization
	void Start () 
	{
//		Debug.Log("敌机子弹已产生！");
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector3.down* Time.deltaTime * speed,Space.World);
	}

	void OnCollisionEnter2D(Collision2D coll) //敌机子弹
	{
		if(coll.gameObject.name=="f16a")
		{
			Destroy(transform.gameObject);
			hp.bloods-=5;  //飞机的生命值减少
		}
	}
}
