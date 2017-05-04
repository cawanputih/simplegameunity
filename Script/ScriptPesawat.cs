using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptPesawat : MonoBehaviour {

    public int kecepatan;
    public static int score;
    public static Vector2 posisipesawatsekarang;

    Text infoskor;
	// Use this for initialization
	void Start () {
        infoskor = GameObject.Find("Skor").GetComponent<Text>();
        score = 0;
        print("Semangat");
	}
	
	// Update is called once per frame
	void Update () {
        posisipesawatsekarang = transform.position;
        infoskor.text = "Skor : " + score.ToString();
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * kecepatan * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.right * -kecepatan * Time.deltaTime);
        }
	}
}
