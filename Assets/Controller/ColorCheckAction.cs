using UnityEngine;
using System.Collections;

public class ColorCheckAction : MonoBehaviour {

    private Player player;

    void Start()
    {
        player = gameObject.transform.parent.GetComponent<Player>();
        //player = gameObject.GetComponent<Player>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
       player.colorCheck = false;
    }

    void OnTriggerStay2D(Collider2D col)
    {
        player.colorCheck = false;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        player.colorCheck = true;
    }
}
