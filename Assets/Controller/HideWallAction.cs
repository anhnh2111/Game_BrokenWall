using UnityEngine;
using System.Collections;

public class HideWallAction : MonoBehaviour {

    private Wall wall;
    private Player player;
    private Renderer render;


    // Use this for initialization
    void Start () {
        wall = gameObject.transform.parent.GetComponent<Wall>();
        player = gameObject.transform.parent.GetComponent<Player>();
        render = gameObject.transform.parent.GetComponent<Renderer>();

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        print(gameObject.name + " OnCollisionEnter2D HIDE voi " + col.gameObject.name);
    }

    void OnCollisionExit2D(Collision2D col)
    {
        print(gameObject.name + " OnCollisionExit2D HIDE voi " + col.gameObject.name);
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        print(gameObject.name + " OnTriggerEnter2D HIDE voi " + col.gameObject.name);
        /*
        if (Input.GetKeyDown(KeyCode.Z))
        {
            render.enabled = false;
            //wall.invi = false;
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            render.enabled = true;
            //wall.invi = false;
        }
        */

    }

    void Update()
    {

    }
}
