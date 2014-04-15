using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {

	public float Speed = 5.0f;
	public Vector3 dir;

	// Use this for initialization
	void Start ()
	{
		dir = new Vector3(1, 1, 0);
		dir.Normalize();
		gameObject.rigidbody2D.AddForce(new Vector2(100 * Speed, 100 * Speed));
	}
	
	// Update is called once per frame
	void Update ()
	{
		//transform.position += dir * Speed * Time.deltaTime;
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		//dir = Vector3.Reflect(dir, new Vector3(collision.contacts[0].normal.x, collision.contacts[0].normal.y, 0));
		Vector3 n = new Vector3(collision.contacts[0].normal.x, collision.contacts[0].normal.y, 0);
		Vector3 v = new Vector3(gameObject.rigidbody2D.velocity.x, gameObject.rigidbody2D.velocity.y, 0);

		Vector3 reflectVec = Vector3.Reflect(v, n);

		Vector2 inputVec = new Vector2(reflectVec.x, reflectVec.y);

		gameObject.rigidbody2D.AddForce(collision.contacts[0].normal * Speed * 100);
		//gameObject.rigidbody2D.AddForce(inputVec * Speed * 100);
		Debug.Log("Ceiling collision");
		//dir.Normalize();
		//if (collision.gameObject.tag == Statics.CeilingTag)
		//{
			//Debug.Log("Ceiling collision");
			//dir.y *= (-1);
		//}

		//if (collision.gameObject.tag == Statics.WallTag)
		//{
			//Debug.Log("Wall collision");
			//dir.x = dir.x * (-1);
		//}
	}
}
