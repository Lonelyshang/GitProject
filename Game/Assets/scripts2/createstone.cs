using UnityEngine;
using System.Collections;

public class createstone : MonoBehaviour {

	public GameObject prb_stone;

	private float MinSpeed=20;
	private float MaxSpeed=40;
	private float MinRotateSpeed = 1f;
	private float MaxRotateSpeed = 2f;
	private float MinScale = 20f;
	private float MaxScale = 70f;
	private float CurrentRotationSpeed;
	private float currentScaleX;
	private float currentScaleY;
	private float currentScaleZ;
	
	private float currentSpeed;
	private float x, y, z;

	private GameObject rote;

	public static Vector3 vect;
	
	// Use this for initialization
	void Start()
	{
		SetPositionAndSpeed();
		StartCoroutine(creStone());
	}

		IEnumerator creStone()
		{
	   		while(true&&!ui.signal)
			{
				SetPositionAndSpeed();
				rote=(GameObject)Instantiate(prb_stone,vect,new Quaternion(0,0,0,0));
				Destroy(rote,5);
				yield return new WaitForSeconds(2);
			}
		}

	// Update is called once per frame
	void Update()
	{
//		float amtToMove = currentSpeed * Time.deltaTime;
//		transform.Rotate(new Vector3(-1, 0, 0)* 1);
//		prb_stone.transform.Translate(Vector3.down * amtToMove, Space.World);
//
//		if(prb_stone.transform.position.y <= 35f)
//		{
//			SetPositionAndSpeed();
//			Player.Missed++;
//		}

	}
	
	public void SetPositionAndSpeed()
	{
		CurrentRotationSpeed = Random.Range(MinRotateSpeed, MaxRotateSpeed);
		currentScaleX = Random.Range(MinScale, MaxScale);
		currentScaleY = Random.Range(MinScale, MaxScale);
		currentScaleZ = Random.Range(MinScale, MaxScale);
		
		currentSpeed = Random.Range(MinSpeed, MaxSpeed);
		x = Random.RandomRange(-50f, 50f);
		y = 110f;
		z = 0;
		
		prb_stone.transform.position = new Vector3(x, y, z);
		vect = new Vector3(x, y, z);
		prb_stone.transform.localScale = new Vector3(currentScaleX, currentScaleY, currentScaleZ);
	}
}
