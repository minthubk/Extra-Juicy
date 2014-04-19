using UnityEngine;
using System.Collections;

public enum PlayerNum
{
	Player1,
	Player2
}

public class PaddleMovement : MonoBehaviour {
	
	public float Speed = 5;
	public float UpperBound;
	public float LowerBound;
	public PlayerNum PlayerSlot = PlayerNum.Player1;
	private float vertDir;

	void Update()
	{
		if (PlayerSlot == PlayerNum.Player1)
		{
			vertDir = Input.GetAxis("P1Vertical");
		}
		else
		{
			vertDir = Input.GetAxis("P2Vertical");
		}

		transform.position += Vector3.up * vertDir * Speed * Time.deltaTime;
		
		if (transform.position.y > UpperBound || transform.position.y < LowerBound)
			transform.position -= Vector3.up * vertDir * Speed * Time.deltaTime;
	}
}
