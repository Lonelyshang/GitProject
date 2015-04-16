using UnityEngine;
using System.Collections;

public class planeBullet : MonoBehaviour 
{
	//子弹方向
	public GameObject prb_up; 
	public GameObject prb_sp1; 
	public GameObject prb_sp2; 

	//	//子弹实例
	public GameObject prb_zd_up;
	
	private  GameObject zd_prb;
//	public  GameObject zd_prb1;
//	public  GameObject zd_prb2;
	public  AudioClip audi;
	private AudioSource audio;

	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if ((Input.GetKeyDown(KeyCode.J)||Input.GetKeyDown(KeyCode.Space)))
		{
			audio= gameObject.AddComponent<AudioSource>();
			audio.clip=audi;
			audio.volume=0.7f;
			audio.Play();
			zd_prb=(GameObject)Instantiate(prb_zd_up,prb_up.transform.position,new Quaternion(0,0,0,0));
			Destroy(zd_prb,2);
			Destroy((GameObject)Instantiate(prb_zd_up,prb_sp1.transform.position,new Quaternion(0,0,0,0)),2);
			Destroy((GameObject)Instantiate(prb_zd_up,prb_sp2.transform.position,new Quaternion(0,0,0,0)),2);


//			zd_prb.tag="zd1";
//			Destroy(zd_prb,2); //克隆子弹返回实例 2秒销毁
//			prb_sp1=(GameObject)Instantiate(prb_zd_up,prb_sp1.transform.position,new Quaternion(0,0,0,0));
//			prb_sp1.tag="zd2";
//			Destroy(prb_sp1,2);
//			prb_sp2=(GameObject)Instantiate(prb_zd_up,prb_sp2.transform.position,new Quaternion(0,0,0,0));
//			prb_sp1.tag="zd3";
//			Destroy(prb_sp2,2);

		}
	}

//	void OnCollisionEnter2D(Collision2D coll) //
//	{
//		Debug.Log("111");
//		coll.gameObject.SetActive(false);
//	}
}





