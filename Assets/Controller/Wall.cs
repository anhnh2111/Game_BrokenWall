using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

    public float speed = 30f;
    public bool invi;

    private Rigidbody2D rb2d;
    private Collider2D col2d;

    // Use this for initialization
    void Start () {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        //col2d = gameObject.GetComponent<Collider2D>();

        // freeze Z
        rb2d.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update() {

        Vector3 vtWall = new Vector3();
        transform.position += vtWall * speed * Time.deltaTime;
        
        if (invi)
        {
           rb2d.AddForce(Vector2.left * 0);
        }else
        {
            rb2d.AddForce(Vector2.left * speed * 2);
        }
    }

    void FixedUpdate()
    {

    }
}
