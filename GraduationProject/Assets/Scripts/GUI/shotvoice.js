#pragma strict
//引入声音源
@script RequireComponent(AudioSource)
//定义变量指向另一个声音片段资源
var SecondSong:AudioClip;

function Start () {
	audio.loop = true;
}

function OnGUI() {//设置点击GUI上的各个按钮所对应的事件
	if(GUILayout.Button("Play/Continue"))
	{
		if(!audio.isPlaying)
		{
			audio.Play();
		}
	}
	if(GUILayout.Button("Pause"))
	{
		audio.Pause();
	}
	if(GUILayout.Button("stop"))
	{
		audio.Stop();
	}
	if(GUILayout.Button("Play another song"))
	{
		audio.Stop();
		audio.PlayOneShot(SecondSong);
	}
}