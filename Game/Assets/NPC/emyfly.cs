using UnityEngine;
using System.Collections;

public class emyfly : MonoBehaviour {
	//敌机运行轨迹

	public float speed=30f;
	public Vector3 vect;

	public GameObject bloom;

	// Use this for initialization
	void Start () 
	{
			vect=Vector3.left;
			StartCoroutine(enemyFly());
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(vect* Time.deltaTime * speed , Space.World);
	}

	private IEnumerator enemyFly() //呈矩形飞行
	{
		yield return new WaitForSeconds(2.5f);
		vect = Vector3.down;
		yield return new WaitForSeconds(0.8f);

		vect = Vector3.right;
		yield return new WaitForSeconds(2.5f);
		vect = Vector3.up;
		yield return new WaitForSeconds(0.8f);
		vect = Vector3.left;

	}

	void OnCollisionEnter2D(Collision2D coll) //
	{
		if(coll.gameObject.tag=="Player")
		{
			Destroy(Instantiate(bloom,coll.transform.position,new Quaternion(0,0,0,0)),2);
			hp.bloods-=5;
			Destroy(transform.gameObject);
		}
	}
//	private IEnumerator enemyFly1() //顺时针飞行
//	{
//		yield return new WaitForSeconds(1);
//		vect=Vector3.down;
//		yield return new WaitForSeconds(1);
//		vect=Vector3.left;
//		yield return new WaitForSeconds(2);
//	}
}





