using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    public float spawnTime = 3f;
    public Transform[] spawnPoints;
    public GameObject enemy;
    int limite = 0;
    public static int qtdZumbi = 3;

    // Use this for initialization
    void Start () {
        //InvokeRepeating("Spaw", spawnTime, spawnTime);
	}

    private void Update()
    {
        if (limite < qtdZumbi)
        {
            int spawnPointIndex = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy, spawnPoints[spawnPointIndex].position,
                        spawnPoints[spawnPointIndex].rotation);
            limite++;
        }
    }
}
