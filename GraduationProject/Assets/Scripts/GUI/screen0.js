#pragma strict
//private var bTexture:Texture2D;
//背景贴图
private var bg : Texture2D;
//标题贴图
//private var title : Texture2D;
//动画数组
private var tex : Object[];
//动画X坐标
private var x:int;
//动画Y坐标
private var y:int;
//帧序列
private var nowFram : int;
//动画帧的总数
private var mFrameCount : int;
//限制一秒多少帧
private var fps : float = 5;
//限制帧的时间 
private var time : float = 0;

private var  text:String;


function Start()
{
	text="Instruction: \n\n\tPress W A S D or right left up down to move \n\n\tPress space to shoot !";
	
   //载入资源
   bg = Resources.Load("SpaceShooter_Start");
//   title = Resources.Load("title");
   //初始化动画坐标
   x = Screen.width;
   y = 200;
}

function OnGUI() 
{
     //GUI.Label(new Rect(10, 100, 200, 50), text);
      
	//绘制贴图
	GUI.DrawTexture(Rect(0,0,Screen.width,Screen.height), bg, ScaleMode.StretchToFill, true, 0);
	
	if(Input.anyKeyDown)
	{
            Application.LoadLevel("plane");
    }
     GUI.contentColor=Color.yellow;
    GUI.Label(Rect(10,10,280,100),text);
  
	//绘制标题
//	GUI.DrawTexture(Rect((Screen.width - title.width)>>1,30,title.width,title.height), title, ScaleMode.StretchToFill, true, 0)
	//绘制帧动画
//	DrawAnimation(tex,Rect(x,y,40,60));
	//动画越界监测
//	x --;
//	if(x <-42)
//	{
//		x =480;
//	}
	
	//绘制按钮
//	if(	GUI.Button(Rect(Screen.width/2-170, Screen.height/3-20, 300, 40),""))
//	{
//		GUI.backgroundColor =Color.white;
//		Application.LoadLevel("plane");
//	}
 
//	GUI.Button(Rect(Screen.width/2-60, Screen.height/3-20, 200, 40),"开始游戏");
//	GUI.Button(Rect(230,200,100,40),"读取进度");
//	GUI.Button(Rect(230,240,100,40),"关于游戏");
//	GUI.Button(Rect(230,280,100,40),"退出游戏");
	
}

//function  DrawAnimation(tex : Object[] , rect : Rect)
//{
//		//绘制当前帧
//		GUI.DrawTexture(rect, tex[nowFram], ScaleMode.StretchToFill, true, 0);
//		//计算限制帧时间
//		time += Time.deltaTime;
//		 //超过限制帧则切换图片
//		 if(time >= 1.0 / fps){
//      	 	 //帧序列切换
//      	 	 nowFram++;
//      	 	 //限制帧清空
//      	 	 time = 0;
//      	 	 //超过帧动画总数从第0帧开始
//      	 	 if(nowFram >= tex.Length)
//      	 	 {
//      	 	 	nowFram = 0;
//      	 	 }
//        }	
//}


//using UnityEngine;
//using System.Collections;
//
//public class MainMenu : MonoBehaviour
//{
//    private string instructionText = "Instruction: \nPress right or left to move \nPress space to fire";
//    public Texture2D background;
//
//    // Use this for initialization
//    void Start()
//    {
//
//    }
//
//    // Update is called once per frame
//    void Update()
//    {
//
//    }
//
//    void OnGUI() {
//        GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height), background);
//        GUI.Label(new Rect(10, 10, 200, 50), instructionText);
//        //if(GUI.Button(new Rect(Screen.width/2-100, Screen.height/2-20, 200, 40), "Start")){
//        //    Application.LoadLevel("PlaneGame");
//        //}
//        if(Input.anyKeyDown){
//            Application.LoadLevel("plane");
//        }
//    }
//}
