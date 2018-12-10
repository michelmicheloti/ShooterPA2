using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyManager : MonoBehaviour {

    public float spawnTime = 3f;
    public Transform[] spawnPoints;
    public GameObject enemy;
    public static int limite = 0;
    public static int qtdZumbi = 4;
    int spawnPointIndex;

    // Use this for initialization
    void Start () {
        //InvokeRepeating("Spaw", spawnTime, spawnTime);
        limite = 0;
	}

    private void Update()
    {
        
        if (limite < qtdZumbi)
        {
            spawnPointIndex = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy, spawnPoints[spawnPointIndex].position,
                        spawnPoints[spawnPointIndex].rotation);
            limite++;
        }

    }
}
