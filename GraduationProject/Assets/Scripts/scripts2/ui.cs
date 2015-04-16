using UnityEngine;
using System.Collections;

public class ui : MonoBehaviour 
{
	public float bloodValue = 0.0f;
	private float tmpValue;//变化的生命值静态全局
	private Rect rctBloodBar;//血条
	private Rect rctUpButton;
	private Rect rctDownButton;
	private bool onoff;
	public static float bloods=100;		//血条初始值
	public static bool signal=false;		//挂了信号,飞机消失
	public static bool vercitary=false;
	
	public static int score=0;
	public static int level=2;
	public static int missed=0;

	// Use this for initialization
	void Start () {
	
	}

	void OnGUI ()
	{

		if(ui.score==3000)
		{
			GUI.color=Color.red;
			GUI.Label(new Rect(Screen.width/2,Screen.height /2-40,100,50),"Well done !");
		}
		if(ui.score>=4000)
		{
			signal=true;
			GUI.color=Color.yellow;
			GUI.Label(new Rect(Screen.width/2-40,Screen.height/2-60, 200,200),"恭喜你，挑战成功!");
			if(GUI.RepeatButton(new Rect(Screen.width/2-30,Screen.height/2+40,100,40),"退出游戏"))
			{
				Application.Quit();//结束程序
			}
		}

		GUI.contentColor=Color.yellow;
		GUI.Label(new Rect(10,40,100,60),"Score: "+ui.score);
		GUI.Label(new Rect(10,60,100,60),"Miss:  "+missed);
		GUI.Label(new Rect(10,80,100,60),"Level: "+level);
		
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
		}
		GUI.Label(new Rect(10,5,200,20),+bloods*10+"/1000 ");
		GUI.HorizontalScrollbar(new Rect(10,20,200,20),0.0f,bloods,0.0f,100.0f);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
