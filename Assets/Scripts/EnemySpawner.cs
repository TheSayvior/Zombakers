using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject Enemy_Basic;

    GameObject player;

    Vector3 spawnLocation;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {

        Vector3 spawnLocation = new Vector3(Random.Range(-10.0f, 10.0f)*10, 0, Random.Range(-10.0f, 10.0f)*10);
        GameObject SpawnedEnemy = Instantiate(Enemy_Basic, spawnLocation, Quaternion.identity);
        SpawnedEnemy.gameObject.SetActive(true);
    }
}
