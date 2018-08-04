using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    CharacterController2D controller;

    float horizontalMove = 0f;
    public float speed;
	// Use this for initialization
	void Start () {
        horizontalMove = Input.GetAxisRaw("Horizontal")* speed;
	}
	
	// Update is called once per frame
	void Update () {
        controller.Move(horizontalMove* Time.fixedDeltaTime,false,false);
	}
}
