using UnityEngine;
using System.Collections;


public class PlayHitSounds : MonoBehaviour {

	public Transform CameraPosition;
	public AudioClip[] HitSounds;

	// Use this for initialization
	void Start()
	{

	}
	
	// Update is called once per frame
	void Update()
	{
		
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		audio.PlayOneShot(HitSounds[Random.Range(0, 3)]);
	}
}