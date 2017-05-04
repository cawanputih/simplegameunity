using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMusuh : MonoBehaviour {

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {

        Destroy(gameObject);
        ScriptPeluru.resetposisi = true;
        ScriptPesawat.score += 10;
    }

}
