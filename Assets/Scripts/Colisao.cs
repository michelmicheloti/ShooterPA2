using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisao : MonoBehaviour {

    public GameObject paticula;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        GameObject.Instantiate(
            paticula,
            transform.position,
            transform.rotation
            );
        GameObject.Destroy(gameObject); 
    }
}
