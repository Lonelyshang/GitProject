using UnityEngine;
using System.Collections;

public class fly : MonoBehaviour 
{
	public static float speed = 30;
	public GameObject ariplne; 
	public static bool relifesuccess=false; //复活标志
	// Use this for initialization
	void Start () 
	{	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if((Input.GetKey(KeyCode.W)||(Input.GetKey(KeyCode.UpArrow)))&&(ariplne.transform.position.y<16)||hp.nextlevel)
		{
			ariplne.transform.Translate(Vector3.up* Time.deltaTime * speed,Space.World);
		}
		if((Input.GetKey(KeyCode.D)||(Input.GetKey(KeyCode.RightArrow)))&&(ariplne.transform.position.x<45))
		{
			ariplne.transform.Translate(Vector3.right* Time.deltaTime * speed,Space.World);
		}
		if((Input.GetKey(KeyCode.A)||(Input.GetKey(KeyCode.LeftArrow)))&&(ariplne.transform.position.x>-45))
		{
			ariplne.transform.Translate(Vector3.left* Time.deltaTime * speed,Space.World);
		}
		if((Input.GetKey(KeyCode.S)||(Input.GetKey(KeyCode.DownArrow)))&&(ariplne.transform.position.y>-18))
		{
//			Debug.Log(ariplne.transform.position);
			ariplne.transform.Translate(Vector3.down* Time.deltaTime * speed,Space.World);
		}
		//当hp.signal==true时说明我方飞机被击败
		if(hp.signal==true)//死亡信号
		{
			randpl.start=false;
			ariplne.SetActive(false);//飞机不可见
		}
		//hp.relife==true时我方飞机复活成功 可见
		if(hp.relife==true)
		{
     		ariplne .SetActive ( true);//使飞机可见
 			relifesuccess =true; //发出复活成功的信号->隐藏重玩按钮
			hp.relife=false;
		}
	}
}