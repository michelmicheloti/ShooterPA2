using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    float auxlados;
    float auxfrente;
    public float speed;
    public GameObject vida;
    int life,tempo=0;
    bool dano = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        auxlados = Input.GetAxis("Horizontal");
        auxfrente = Input.GetAxis("Vertical");

        GetComponent<Rigidbody>().velocity = transform.forward * auxfrente * speed;

        transform.eulerAngles = transform.eulerAngles + Vector3.up * auxlados;

        if (life > 4)
        {
            GameObject.Destroy(vida);
            GameObject.Destroy(gameObject);
            Application.LoadLevel("Fim");
        }

        if (dano == true)
        {
            if(life == 4)
            {
                life++;
            }
            if (tempo > 100)
            {
                life++;
                dano = false;
                tempo = 0;
            }
            tempo++;
        }

    }

    private void OnCollisionEnter(Collision x)
    {
        if(x.transform.tag == "zumbie" && dano == false)
        {
            vida.transform.localScale = new Vector3(
                vida.transform.localScale.x - 1.4f,
                vida.transform.localScale.y,
                vida.transform.localScale.z);

            dano = true;
        }

        if(x.transform.tag == "medkit")
        {
            vida.transform.localScale = new Vector3(
                vida.transform.localScale.x + 1.4f,
                vida.transform.localScale.y,
                vida.transform.localScale.z);
            life--;
        }

        if (x.transform.tag == "armo")
        {
            Atire.qtsTiros += 4;
            Atire.qtsMina += 1;
        }
    }
}
