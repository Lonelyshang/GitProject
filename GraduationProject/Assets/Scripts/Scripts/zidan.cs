using UnityEngine;
using System.Collections;

public class zidan : MonoBehaviour 
{
	//子弹方向
	public GameObject prb_up; 
	public GameObject prb_sp1; 
	public GameObject prb_sp2; 
//	public GameObject prb_right; 
//	public GameObject prb_left;
//	public GameObject prb_down; 
//	
//	
//	//子弹实例
	public GameObject prb_zd_up;

	public static GameObject zd_prb;
//	public GameObject prb_zd_right;
//	public GameObject prb_zd_left;
//	public GameObject prb_zd_down;

	public AudioClip audi;
	private AudioSource audio;
	
	
//	private static Vector3 vect = Vector3.up;
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if ((Input.GetKeyDown(KeyCode.J)||Input.GetKeyDown(KeyCode.Space))&&!hp.signal)
		{
			//			GameObject tm_zd = Instantiate(prb_zd) as GameObject;			
			//			autoFly tm_af = tm_zd.GetComponent<autoFly>();  //获取组件 aotoFly 并赋值给 tm_af 
			//			tm_af.setSpeed(50); //调用setSpeed 方法
			//			Destroy(tm_zd,2);
			
//			if(vect==Vector3.forward)
//			{
			audio= gameObject.AddComponent<AudioSource>();
			audio.clip=audi;
			audio.volume=0.7f;
			audio.Play();
			zd_prb=(GameObject)Instantiate(prb_zd_up,prb_up.transform.position,new Quaternion(0,0,0,0));
			Destroy(zd_prb,2); //克隆子弹返回实例 2秒销毁

//			}
//			if(false)//三个子弹
//			{
//				Destroy(Instantiate(prb_zd_up,prb_sp1.transform.position,new Quaternion(0,0,0,0)),2);
//				Destroy(Instantiate(prb_zd_up,prb_sp2.transform.position,new Quaternion(0,0,0,0)),2);
//			}

//			if(vect==Vector3.right)
//			{
//				Destroy(Instantiate(prb_zd_right,prb_right.transform.position,new Quaternion(0,0,0,0)),2);
//			}
//			if(vect==Vector3.left)
//			{
//				Destroy(Instantiate(prb_zd_left,prb_left.transform.position,new Quaternion(0,0,0,0)),2);
//			}
//			if(vect==Vector3.back)
//			{
//				Destroy(Instantiate(prb_zd_down,prb_down.transform.position,new Quaternion(0,0,0,0)),2);
//			}
		}
	}
	
//	public static void setvect(Vector3 ve)
//	{
//		vect=ve;
//	}
}
