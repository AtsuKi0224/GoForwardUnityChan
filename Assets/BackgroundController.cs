using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour {


    private float translatespeed = -0.03f;

    private float deadline = -16f;

    private float startpos = 15.8f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(translatespeed, 0, 0);

        if(transform.position.x < deadline){
            transform.position = new Vector2(startpos, 0);
        }

	}
}
