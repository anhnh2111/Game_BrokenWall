using UnityEngine;
using System.Collections;

public class kingkongController : MonoBehaviour {

    public Sprite[] sprites;
    public bool changeColor;
    public int index;

    private SpriteRenderer spriteRenderer;
    
    // Use this for initialization
    void Start () {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        index = 0;
        if (Input.GetButtonDown("Fire1"))
        {
            changeColor = !changeColor;
        }

        index = (changeColor) ? 0 : 1;

        spriteRenderer.sprite = sprites[index];
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        print(gameObject.name + " OnCollisionEnter2D voi " + col.gameObject.name);
        if (changeColor)
        {
            print("Red");
            Destroy(col.gameObject);
        }
        else
            print("Blue");

    }
}
