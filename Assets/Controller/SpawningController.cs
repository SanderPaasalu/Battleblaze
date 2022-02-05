using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningController : MonoBehaviour
{
    private float distasterTimer;
    private float dTimer = 10f;
    private float eTimer = 5f;
    private float spawnTimer;
    public GameObject meteor;
    public GameObject enemyBody;
    // Start is called before the first frame update
    void Start()
    {
        distasterTimer = dTimer;
        spawnTimer = eTimer;
        Instantiate(enemyBody, new Vector2(5, -2), Quaternion.identity);
        Instantiate(enemyBody, new Vector2(-5, 3), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        MeteorSpawn();
        EnemySpawn();
    }

    private void MeteorSpawn()
    {
        distasterTimer -= Time.deltaTime;
        if(distasterTimer <= 0)
        {
            distasterTimer = dTimer;
            Instantiate(meteor);   
        }
    }

    private void EnemySpawn()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            spawnTimer = eTimer;
            Instantiate(enemyBody);
        }
    }
}
