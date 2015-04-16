using UnityEngine;
using System.Collections;

public class enemyattack : MonoBehaviour
{
	//敌机攻击 产生子弹

	public GameObject prb_emy_zzddown;

	public GameObject prb_emy_zdweizhi;

	public static GameObject dijizidan;
	void Start () {
		StartCoroutine(enemyAttack());
	}
	
	IEnumerator enemyAttack()
	{
		
		while(true)
		{
			dijizidan=(GameObject)Instantiate(prb_emy_zzddown,prb_emy_zdweizhi.transform.position,new Quaternion(0,0,0,0));
			Destroy(dijizidan,2);

//			Destroy(Instantiate(prb_emy_zzddown,transform.position,new Quaternion(0,0,0,0)),2);
			yield return new WaitForSeconds(0.5f);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
//		if(n%20==0)
//		{
//			n=0;
//			Destroy(Instantiate(prb_emy_zzddown,transform.position,new Quaternion(0,0,0,0)),2);
//		}
//		n++;
	}
}
