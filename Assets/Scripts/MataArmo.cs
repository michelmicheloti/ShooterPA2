using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MataArmo : MonoBehaviour {

    public GameObject municao;

    private void OnCollisionEnter(Collision x)
    {
        if (x.transform.tag == "Player")
        {
            GameObject.Destroy(gameObject);
        }
    }
}
