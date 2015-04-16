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
	public GameObject Lase;
	
	private  GameObject zd_prb;
//	public  GameObject zd_prb1;
//	public  GameObject zd_prb2;
	public  AudioClip audi;
	private AudioSource audio;

	private static bool change;

	private static bool changed;

	
	// Use this for initialization
	void Start () 
	{
		change=false;
		changed=false;
	}

	IEnumerator begin()
	{
		while(true)
		{
			Destroy(Instantiate(Lase,prb_up.transform.position,new Quaternion(0,0,0,0)),2);
			yield return new WaitForSeconds(0.3f);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(!change)
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
			}
		}
		else
		{
			if(changed)
			{
				changed=false;
				StartCoroutine(begin());
			}
		}
				
		if(Input.GetKeyDown(KeyCode.I))
		{
			change=!change;
			StopAllCoroutines();
			changed=true;
		}
	}
}





