using UnityEngine;

public class playerMovement : MonoBehaviour {

	public Rigidbody rb;

	public float forwardForce = 200f;
	public float sidewaysForce = 500f;
	// Use this for initialization
	void Start () {
		
	}
	
	// We marked this as "Fixed"Update because we are using it to mess physics
	void FixedUpdate () {
		//add a forward force
		rb.AddForce(0,0,forwardForce*Time.deltaTime);
		if(Input.GetKey("d")){
			rb.AddForce(sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
		if(Input.GetKey("a")){
			rb.AddForce(-sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
	}
}
