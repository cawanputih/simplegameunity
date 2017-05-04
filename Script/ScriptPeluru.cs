using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScriptPeluru : MonoBehaviour {

	// Use this for initialization
   
    public int kecepatan;
    public Rigidbody2D tembak;
    public int kekuatantembak;
    public static bool resetposisi;



	void Start () {
        
        tembak = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Space))
        {
            tembak.AddForce(new Vector2(0, kekuatantembak));
        }
        else
        {
            if (resetposisi || (transform.position.y > 4.6))
            {
                //print(transform.position);
                transform.position = ScriptPesawat.posisipesawatsekarang;
                resetposisi = false;
                tembak.velocity = new Vector2(0, 0);
            }
        }
	}

    

}
