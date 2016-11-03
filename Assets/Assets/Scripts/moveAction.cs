using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class moveAction : MonoBehaviour
{
    public static float maxSpeed = 20f;
    public float speed = 10f;
    public bool changeColor;
    public List<GameObject> exitNodes;
    
    //private Rigidbody2D rb2d;

    void Awake()
    {
        exitNodes = new List<GameObject>();
        CreateList();
    }

    // Use this for initialization
    void Start()
    {
        //rb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    private void CreateList()
    {
        for (int i = 0; i < 3; i++)
        {
            Vector3 rndPos;
            rndPos = new Vector3(Random.Range(10, 30), Random.Range(10, 30));

            GameObject node;
            node = Instantiate(gameObject, rndPos, Quaternion.identity) as GameObject;

            exitNodes.Add(node);
            Debug.Log(exitNodes.Count);
        }
    }
   
    // Update is called once per frame
    void Update()
    {
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
