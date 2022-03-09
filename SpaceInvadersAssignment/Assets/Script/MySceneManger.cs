using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MySceneManger : MonoBehaviour {
    public Text text;
    public int hits;
	// Use this for initialization
	void Start () {
		
	}
    private void Update()
    {
        //text.text = "HighScore:" + hits;  
    }

    public void RegisterHit()
    {
        hits++;
    }
}
