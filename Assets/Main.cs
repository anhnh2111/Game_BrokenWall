using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

    public float speed = 30f;

    private GameObject player;
    private GameObject wall;
    private GameObject background;
   
    // Use this for initialization
    void Start () {
        background = GameObject.FindGameObjectWithTag("MainCamera");
        player = GameObject.FindGameObjectWithTag("Player");
        wall = GameObject.FindGameObjectWithTag("Respawn");


        print("Player Name : " + player.name);
        print("wall Name : " + wall.name);


        background = GameObject.CreatePrimitive(PrimitiveType.Plane);

        //player = GameObject.CreatePrimitive(PrimitiveType.Cube);
        player.transform.position = new Vector3(0, 0,-1);

        //wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
        wall.transform.position = new Vector3(20, 0, -1);
                

    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
