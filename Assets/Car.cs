﻿using UnityEngine;

public class Car : MonoBehaviour {

	public Rigidbody2D rb;
	public float speed = 1f;
	public float minSpeed = 3f;
	public float maxSpeed = 6f;

	void start(){
		speed = Random.Range(minSpeed,maxSpeed);
	}

	void FixedUpdate(){
		Vector2 forward = new Vector2(transform.right.x, transform.right.y);
		rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
	}
}
