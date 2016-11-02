using UnityEngine;
using System.Collections;

public class moveAction : MonoBehaviour
{
    public static float maxSpeed = 20f;
    public float speed = 10f;
    public bool changeColor;

    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vtWall = new Vector3();
        transform.position += vtWall * speed * Time.deltaTime;
        rb2d.AddForce(Vector2.left * speed * 2);
    }

    void FixedUpdate()
    {
        // Limiting the speed
        if (rb2d.velocity.x > maxSpeed)
        {
            rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
        }
    }
}
