using UnityEngine;
using System.Collections;

public class randpl : MonoBehaviour 
{
	//产生敌机
	public static bool start=true; //再次产生敌机

	public GameObject diji;
		
    public static	int num = 0;

	public static int planeNum=0;

	public static  bool flag=false;

    GameObject[] randiji;
	// Use this for initialization
	void Start () 
	{
		randiji =new GameObject[100] ;

		//产生敌机
		StartCoroutine(enemyPlant());

		StartCoroutine(Destroyplne());

	}
	
	private IEnumerator enemyPlant()//协同程序产生敌机
	{
//		Debug.Log("协同程序执行中");
//		Debug.Log ("hp.relief:"+hp.relife);
		while(start)
		{
			randiji[planeNum]=(GameObject)Instantiate(diji,new Vector3(40,18f,0), transform.rotation);
			planeNum++;
			if(planeNum<8)
			{
				yield return new WaitForSeconds(1f);
			}
			else
			{
				yield return new WaitForSeconds(1.5f);
			}
			//yield return new WaitForSeconds(1f);
			if(hp.score==2000)//不再产生敌机标志
			{
				start=false;
				//fly.relifesuccess=false;
			}

		}
//		Debug.Log (planeNum);
		//StopAllCoroutines();
	}

	private IEnumerator Destroyplne() //隔段时间销毁一只
	{
		for(int i=0;i<planeNum;i++)
		{
			if(randiji[i]!=null)
			{
				Destroy(randiji[i]);
				//Debug.Log(i);
			}
			yield return new WaitForSeconds(4f);
		}
	}
	void Update () 
	{
//		flag=hp.relife;
		//Debug.Log (planeNum);
	}
}

//private IEnumerator reliefEnemyPlant()//协同程序产生敌机
//{
//	while(hp.relife)
//	{
//		randiji[planeNum]=(GameObject)Instantiate(diji,new Vector3(40,18f,0), transform.rotation);
//		planeNum++;
//		if(planeNum<8)
//		{
//			yield return new WaitForSeconds(1f);
//		}
//		else
//		{
//			yield return new WaitForSeconds(1.5f);
//		}
//		//yield return new WaitForSeconds(1f);
//		if(hp.score==2000)//不再产生敌机标志
//		{
//			start=false;
//			//	fly.relifesuccess=false;
//		}
//	}
//	num=0;
//	//StopAllCoroutines();
//}



//	private IEnumerator Destroyplne() //隔段时间销毁一只
//	{
//
//		for(int i=0;i<8;i++)
//		{
//			if(randiji[i]!=null)
//			{
//				Destroy(randiji[i]);
//				Debug.Log(i);
//			}
//			yield return new WaitForSeconds(4f);
//		}
//	}
//
//		// Update is called once per frame
//void Update () //销毁敌机
//{
	//Debug.Log ("TotalNUm1"+TotalNum);
//}
//}
