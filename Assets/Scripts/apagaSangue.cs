using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apagaSangue : MonoBehaviour {

    int tempo = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (seguir.DSangue == true)
        {
            tempo++;
            if (tempo > 200)
            {
                GameObject.Destroy(gameObject);
                tempo = 0;
                seguir.DSangue = false;
            }
        }
    }
}
