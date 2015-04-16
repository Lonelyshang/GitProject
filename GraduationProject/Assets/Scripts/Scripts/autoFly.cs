using UnityEngine;
using System.Collections;


public class autoFly : MonoBehaviour
{
	private float speed = 60;
	GameObject zd;
//	public AudioSource audio;
	private AudioClip m_PlayClip;
	public GameObject gobj_boom;//粒子

	private GameObject tm_boom;

	// Use this for initialization
	void Start () 
	{
		
	}
	// Update is called once per frame
	void Update () 
	{
			transform.Translate(Vector3.up* Time.deltaTime * speed,Space.World);
	}

	void OnCollisionEnter2D(Collision2D coll) //
	{
		if(coll.gameObject.tag!="Player")
		{
			tm_boom = (GameObject)Instantiate(gobj_boom,coll.transform.position,new Quaternion(0,0,0,0));
			Destroy(tm_boom,2);//实例后销毁粒子效果
			Destroy(transform.gameObject);
			Destroy(coll.gameObject);

			if(coll.gameObject.tag=="Enemy")
			{
				hp.score+=100; // 游戏加分
			}
	//		Debug.Log("Score:"+hp.score);
		}
	}

}

//public void  PlayBG(string fileName)
//{
//	if (!fileName.Equals(m_CurMusicName))
//	{
//		m_PlayClip = Resources.Load("Resources/Materials/Materials/"+fileName) as AudioClip;
//		m_AudioMgr.clip = m_PlayClip;
//		m_AudioMgr.Play();
//		m_CurMusicName = fileName;
//	}
//	
//	Debug.Log("AudioManager::Play()");
//}


//在time秒调用methodName方法；简单说，根据时间调用指定方法名的方法.

//using UnityEngine;
//using System.Collections;
//
//public class example : MonoBehaviour {
//	public Rigidbody projectile;
//	void LaunchProjectile() {
//		Rigidbody instance = Instantiate(projectile);
//		instance.velocity = Random.insideUnitSphere * 5;
//	}
//	public void Awake() {
//		Invoke("LaunchProjectile", 2);
//	}
//}// Launches a projectile in 2 seconds
//// 2秒后发射炮弹
//var projectile : Rigidbody;
//
//Invoke("LaunchProjectile", 2);
//
//function LaunchProjectile () {
//	var instance : Rigidbody = Instantiate(projectile);
//	instance.velocity = Random.insideUnitSphere * 5;
//}
