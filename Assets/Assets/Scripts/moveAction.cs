using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class moveAction : MonoBehaviour
{
    public static float maxSpeed = 20f;
    public float speed = 10f;
    public bool changeColor;
    public int i = 0;

    private Rigidbody2D rb2d;
    private Transform trans;

    void Awake()
    {
        rb2d = GameObject.Find("wall-red").GetComponent<Rigidbody2D>();
        print("aaa");
    }

    // Use this for initialization
    void Start()
    {       
        print("start" + i++);
    }

    public void CreateList()
    {
        Vector3 rndPos;
        rndPos = new Vector3(Random.Range(10, 15), Random.Range(0, 10), 0);

        //Rigidbody2D node;
        rb2d = Instantiate(rb2d, rndPos, Quaternion.identity) as Rigidbody2D;

         //exitNodes.Add(node);
        //Debug.Log(exitNodes.Count);
    }
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            CreateList();
        }
        //Vector3 vtWall = new Vector3();
        //transform.position += vtWall * speed * Time.deltaTime;
        //rb2d.AddForce(Vector2.left * speed * 2);
    }

    void FixedUpdate()
    {
        // Limiting the speed
        //if (rb2d.velocity.x > maxSpeed)
        {
            //rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
        }
    }
}
