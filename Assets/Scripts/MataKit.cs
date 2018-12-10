using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MataKit : MonoBehaviour {

    public GameObject kite;

    private void OnCollisionEnter(Collision x)
    {
        if (x.transform.tag == "Player")
        {
            GameObject.Destroy(gameObject);
        }
    }
}
