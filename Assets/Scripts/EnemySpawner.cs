using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject Enemy_Basic;
    public float SpawnDistanceToPlayer = 75;

    GameObject player;
    

    Vector3 spawnLocation;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {

        Vector3 spawnLocation = (player.transform.position - new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f))).normalized * SpawnDistanceToPlayer;

        GameObject SpawnedEnemy = Instantiate(Enemy_Basic, new Vector3(spawnLocation.x, 0, spawnLocation.z), Quaternion.identity);
        SpawnedEnemy.gameObject.transform.SetParent(this.gameObject.transform);
        SpawnedEnemy.gameObject.SetActive(true);
    }
}
