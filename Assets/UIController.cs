using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

    private GameObject RunlengthText;

    private GameObject GameOverText;

    private bool isGameOver = false;

    private float len = 0;

    private float speed = 0.03f;


    


	// Use this for initialization
	void Start () {
        this.RunlengthText = GameObject.Find("RunLength");

        this.GameOverText = GameObject.Find("GameOver");
		
	}
	
	// Update is called once per frame
	void Update () {

        if(isGameOver == false){

            this.len += this.speed;

            this.RunlengthText.GetComponent<Text>().text = "Distance:  " + len.ToString("F2") + "m";
        }

        if(isGameOver == true){
            if(Input.GetMouseButton(0)){
                SceneManager.LoadScene("GameScene");
            }
        }
		
	}
    public void GameOver(){
        this.GameOverText.GetComponent<Text>().text = "GameOver";
        this.isGameOver = true;
    }
}
