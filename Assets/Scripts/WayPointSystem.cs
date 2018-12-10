using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WayPointSystem : MonoBehaviour {

    public GameObject jogador;
    public GameObject[] waypoints;
    public int num = 0;

    public float minDist;
    public float speed;

    public bool rand = false;
    public bool go = true;

    int tempo = 0;

	void Start () {
		
	}
	
	void Update () {
        float dist = Vector3.Distance(gameObject.transform.position, waypoints[num].transform.position);

        if (tempo < 800)
        {
            if (go)
            {
                if (dist > minDist)
                {
                    Move();
                }
                else
                {
                    if (!rand)
                    {
                        if (num + 1 == waypoints.Length)
                        {
                            num = 0;
                        }
                        else
                        {
                            num++;
                        }
                    }
                    else
                    {
                        num = Random.Range(0, waypoints.Length);
                    }
                }
            }
        }
        else
        {
            GetComponent<NavMeshAgent>().SetDestination(jogador.transform.position);
        }
        tempo++;

        
	}

    public void Move()
    {
        gameObject.transform.LookAt(waypoints[num].transform.position);
        gameObject.transform.position += gameObject.transform.forward * speed * Time.deltaTime;
    }
    

}
