using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atire : MonoBehaviour {

    public GameObject bala;
    public GameObject arms;
    public GameObject mina;
    GameObject temp,tempMina;
    int VelocidadeMunicao = 2;
    public static int qtsTiros = 10;
    public static int qtsMina = 3;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Mouse0) && qtsTiros > 0){
            temp = GameObject.Instantiate(
                bala,
                arms.transform.position,
                arms.transform.rotation
                );
            qtsTiros--;
        }
        if (Input.GetKeyDown(KeyCode.Mouse1) && qtsMina > 0){
            GameObject.Instantiate(
                mina,
                arms.transform.position,
                arms.transform.rotation
                );
            qtsMina--;
        }

        temp.GetComponent<Rigidbody>().AddForce(transform.forward * VelocidadeMunicao);

	}
}
