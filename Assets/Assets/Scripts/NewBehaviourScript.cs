using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject myGameObject;
    public List<GameObject> goList;
    public WallAnimator wallAction;

    // Use this for initialization
    void Start () {
        goList = new List<GameObject>();
        wallAction = GetComponent<WallAnimator>();

        myGameObject = GameObject.Find("wall-red");
    }

    private void CreateGameObject()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(myGameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Vector3 rndPos = new Vector3(Random.Range(0, 20), Random.Range(0, 20));

            myGameObject.transform.position = rndPos;
            goList.Add(myGameObject);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log(goList.Count);
            foreach (GameObject go in goList)
            {
                Debug.Log(go.name);
            }
        }
    }


}
