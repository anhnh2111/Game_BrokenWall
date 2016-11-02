using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour{

    public float maxSpeed = 1;
    public float speed = 10f;
    public float jumpPower = 500f;

    public bool colorCheck;

    private Rigidbody2D rb2d;
    private Animator anim;
    //private Camera camera;

    void Start() {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        //camera = gameObject.GetComponent<Camera>();

        // freeze Z
        rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;

    }

    // Update is called once per frames
    void Update() {

        anim.SetBool("Grounded", colorCheck);
        anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));

        // Moving the player
        Vector3 move;
        move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += move * speed * Time.deltaTime;
        

        //if(Input.GetAxis("Horizontal") > 0.1f)
        //{
        //    transform.localScale = new Vector3(1, 1, 1);
        //}

        if (Input.GetButtonDown("Jump") && !colorCheck)
        {
            rb2d.AddForce(Vector2.up * jumpPower);
        }

        //transform.localScale = 

    }

    void FixedUpdate() {

        // Limiting the speed of the player
        if(rb2d.velocity.x > maxSpeed) {
            rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
        }


          
    }
}
 