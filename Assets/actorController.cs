using UnityEngine;
using System.Collections;

public class actorController : MonoBehaviour {

    public float moveSpeed;
    // You’ll use turnSpeed in your calculations to control how quickly the zombie reorients himself to a new direction.
    public float turnSpeed;

    private Vector3 moveDirection;
    
    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 currentPosition = transform.position;

        if (Input.GetButton("Fire1"))
        {
            Vector3 moveToward = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moveDirection = moveToward - currentPosition;
            moveDirection.z = 0;
            //moveDirection.y = 0;
            moveDirection.Normalize();
        }

        Vector3 target = moveDirection * moveSpeed + currentPosition;
        transform.position = Vector3.Lerp(currentPosition, target, Time.deltaTime);

        //That’s because the Quaternion.Euler method lets you create a Quaternion object from an Euler angle. 
        //Euler angles are the ones most people are accustomed to, consisting of individual x, y and z rotations. 
        //While they aren’t ideal for 3D work because of problems like gimbal lock, Euler angles are just fine for 2D games where you probably only want to rotate around the z-axis.
        float targetAngle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
        transform.rotation =
          Quaternion.Slerp(transform.rotation,
                            Quaternion.Euler(0, 0, targetAngle),
                            turnSpeed * Time.deltaTime);
    }
}
