using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

	public float speed = 10f;
	public float jump = 10f;


	public Rigidbody rb;

	private bool onGround=false;
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("d")){
			rb.AddForce(speed*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
		if(Input.GetKey("a")){
			rb.AddForce(-speed*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
		if(Input.GetKey("space")&&onGround){
			rb.AddForce(0,jump*Time.deltaTime,0,ForceMode.VelocityChange);
		}
	}

	void OnCollisionEnter(Collision col){
		if(col.collider.tag=="Platform"){
			
			onGround=true;
		}
	}
	void OnCollisionExit(Collision col){
		if(col.collider.tag=="Platform"){
			
			onGround=false;
		}
	}


}
