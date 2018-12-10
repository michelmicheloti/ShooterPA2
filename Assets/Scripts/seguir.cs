using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class seguir : MonoBehaviour {

    public GameObject jogador;
    public GameObject sangue;
    public static bool DSangue = false;
    public GameObject barra;
    public GameObject municao;
    public GameObject kit;
    int life;
    bool dano = false;
    bool persegue = false;
    int muni;
    public static int ZumbiMorto = 0;



    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        if (persegue == true)
        {
            GetComponent<NavMeshAgent>().SetDestination(jogador.transform.position);
            persegue = false;
        }

        if (life > 3)
        {
            GameObject.Destroy(barra);
            GameObject.Destroy(gameObject);
            ZumbiMorto++;
            GameObject.Instantiate(sangue,
                transform.position = new Vector3(transform.position.x, 0.01f, transform.position.z),
                transform.rotation
                );
            DSangue = true;

            muni = Random.Range(0, 3);
            recarga();
        }

        if (dano == true)
        {
            life++;
            dano = false;
        }

        if (ZumbiMorto == (EnemyManager.qtdZumbi)+1)
        {
            Application.LoadLevel("Ganhou");
            ZumbiMorto = 0;
        }

    }

    private void OnCollisionEnter(Collision c)
    {
        if (c.transform.tag == "bala")
        {
            barra.transform.localScale = new Vector3(
                barra.transform.localScale.x - 0.3f,
                barra.transform.localScale.y,
                barra.transform.localScale.z);

            dano = true;
        }

        if (c.transform.tag == "mina")
        {
            GameObject.Destroy(barra);
            GameObject.Destroy(gameObject);
            ZumbiMorto++;
            GameObject.Instantiate(sangue,
                transform.position = new Vector3(transform.position.x, 0.01f, transform.position.z),
                transform.rotation
                );
            DSangue = true;

            muni = Random.Range(0, 3);
            recarga();
        }

    }

    private void OnTriggerExit(Collider other)
    {
        persegue = true;
    }

    void recarga()
    {
        if (muni == 1 || muni == 3)
        {
            GameObject.Instantiate(
                municao,
                transform.position = new Vector3(transform.position.x, 0.05f, transform.position.z),
                transform.rotation = new Quaternion(0f,90f,0f,0f)
            );
        }
        else
        {
            GameObject.Instantiate(
                kit,
                transform.position = new Vector3(transform.position.x, 0.03f, transform.position.z),
                transform.rotation = new Quaternion(0f, 0f, -90f, 90f)
            );


        }
    }
}
