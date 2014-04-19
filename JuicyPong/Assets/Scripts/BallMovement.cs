using UnityEngine;

public class BallMovement : MonoBehaviour {
	
	public float InitialForce = 100.0f;
	public Vector2 InitialDirection = Vector2.zero;

	// Initialization
	void Start ()
	{
		InitialDirection.Normalize();
		rigidbody2D.AddForce(InitialDirection * InitialForce);
	}
}
