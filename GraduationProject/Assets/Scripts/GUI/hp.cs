using UnityEngine;
using System.Collections;

public class hp : MonoBehaviour
{
	public GUISkin theSkin;
	public float bloodValue = 0.0f;
	private float tmpValue;//变化的生命值静态全局
	private Rect rctBloodBar;//血条
	private Rect rctUpButton;
	private Rect rctDownButton;
	private bool onoff;
	public static float bloods=100;		//血条初始值
	public static bool signal=false;		//挂了信号,飞机消失
	public static bool vercitary=false;

	public static bool relife=false; 		//复活标志
	public static bool nextlevel=false;

	public static int score=0;
	public static int level=1;
	// Use this for initialization
	void Start () 
	{
		rctBloodBar = new Rect (20,20,20,20);
		rctUpButton = new Rect (10,100,40,20);
		rctDownButton = new Rect (10,140,40,20);
	}
	
	void OnGUI ()
	{
		GUI.skin = theSkin;
		if(signal==true)//玩家挑战失败
		{
			if(GUI.RepeatButton(new Rect(Screen.width/2-30,Screen.height/2-40,100,40),"重玩一次"))
			{
			    Application.LoadLevel("begin"); //重新开始
				signal=false;//飞机出现
				randpl.start=true;//再次产生敌机
				relife=true;		//初始化血条
				bloods=100;
				score=0;
				level=1;
				signal=false;
			}
			else if(GUI.RepeatButton(new Rect(Screen.width/2-30,Screen.height/2+40,100,40),"退出游戏"))
			{
				Application.Quit();//结束程序
			}
		}
		if(fly.relifesuccess==true)
		{
			//Debug.Log ("复活成功");
			randpl.start=true;       // 再次 产生敌机????
			signal=false;              // 隐藏 重玩按钮
		}
		if(hp.score>=2000)
		{
			GUI.color=Color.yellow;
			GUI.Label(new Rect(Screen.width/2-40,Screen.height/2+30, 200,200),"恭喜你，进入下一关!");
			randpl.start=false;//不再产生敌机
			nextlevel=true;	// 下一关的标记,飞机飞出屏幕
	
			Application.LoadLevel("second");//下载第二关

		}
	
		GUI.contentColor=Color.yellow;
		GUI.Label(new Rect(10,40,100,60),"Score: "+hp.score);
		GUI.Label(new Rect(10,60,100,60),"Level: "+level);
		GUI.Label (new Rect(10,80,100,60),"Music: ");
//		GUI.Button(new Rect(
	
//		if (GUI.Button (rctUpButton,"加血"))
//		{
//			bloods = 100.0f;
//		}
//		if (GUI.Button (rctDownButton,"减血"))
//		{
//			bloods -= 5f;
//		}
		if (bloods <=0.0f)
		{
			bloods=0.0f;
			GUI.color=Color.red;
			GUI.Label(new Rect(Screen.width/2-30,Screen.height/2-100 ,120,80),"Game Over !");//生命值减少到0发出信号为了下一步的复活
			signal=true;//我方挂了->飞机隐藏
		}
		GUI.Label(new Rect(10,5,200,20),+bloods*10+"/1000 ");
		GUI.HorizontalScrollbar(new Rect(10,20,200,20),0.0f,bloods,0.0f,100.0f);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
