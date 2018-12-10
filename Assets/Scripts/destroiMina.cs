using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroiMina : MonoBehaviour {

    public GameObject minhaQuebrada;

    private void OnCollisionEnter(Collision x)
    {
        if(x.transform.tag == "zumbie")
        {
            GameObject.Destroy(gameObject);
            GameObject.Instantiate(minhaQuebrada,transform.position,transform.rotation);
        }
    }
}
