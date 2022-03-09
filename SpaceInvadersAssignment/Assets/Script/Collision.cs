using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {
    public MySceneManger SceneManger;
	// Use this for initialization
	void Start () {
        GameObject mainCamera = GameObject.Find("Main Camera");

        SceneManger = mainCamera.GetComponent<MySceneManger>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Missle")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            Debug.Log("Hit");

            SceneManger.RegisterHit();
        }
    }
}
