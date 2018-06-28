using UnityEngine;

public class FollowPlay : MonoBehaviour {

	public Transform Target;
	public Vector3 offset;

	public float smoothSpeed = 0.125f;

	void FixedUpdate(){

		Vector3 desiredPosition = Target.position + offset;
		Vector3 smoothPosition= Vector3.Lerp(transform.position, desiredPosition,smoothSpeed);
		transform.position= smoothPosition;

		transform.LookAt(Target);//相机看向所选物(相机会旋转)
	}
}
