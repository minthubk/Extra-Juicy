using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour
{
	public float InitialForce = 100.0f;
	public Vector2 InitialDirection = Vector2.zero;
	public float IncrementalForce = 50.0f;
	public float ForceTimeInterval = 10.0f;

	// Initialization
	void Start ()
	{
		InitialDirection.Normalize();
		rigidbody2D.AddForce(InitialDirection * InitialForce);

		StartCoroutine(AddIncrement());
	}

	// Add a force in the current direction
	void AddIncrementalForce()
	{
		rigidbody2D.AddForce(rigidbody2D.velocity.normalized * IncrementalForce);
	}

	// Call AddIncrementalForce() every ForceTimeInveral seconds
	IEnumerator AddIncrement()
	{
		for (;;)
		{
			AddIncrementalForce();
			yield return new WaitForSeconds(ForceTimeInterval);
		}
	}
}
