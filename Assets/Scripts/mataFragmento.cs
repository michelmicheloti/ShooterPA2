using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mataFragmento : MonoBehaviour {

    bool destroi = false;
    int tempo = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(destroi == true)
        {
            tempo++;
            if (tempo > 100)
            {
                GameObject.Destroy(gameObject);
                tempo = 0;
                destroi = false;
            }
        }

	}

    private void OnCollisionEnter(Collision x)
    {
        destroi = true;
    }
}
