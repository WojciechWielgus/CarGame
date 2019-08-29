using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : Unit
{
    
    
    public GameObject enemyPrefab;
    float[] lines = new float[] { -3.3f, -1.1f, 1.1f, 3.3f };
    public int maxEnemyCount = 5;
    [Range(0,20)]
    public float enemySpawnDelay = 1.0f;
    private float enemySpawnTime;

    private void Start()
    {
        enemySpawnTime = enemySpawnDelay;
    }

    private void Update()
    {
        if(Unit.GameIsRun)
        {
            enemySpawnTime -= Time.deltaTime;

            if (Random.Range(0, 1000) % 13 == 0 && Unit.EnemyCount < maxEnemyCount && enemySpawnTime <= 0)
            {
                Instantiate(enemyPrefab, new Vector3(lines[Random.Range(0, 3)], 0.3f, GetComponent<Transform>().position.z), Quaternion.identity);
                Unit.EnemyCount++;
                enemySpawnTime = enemySpawnDelay;
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                //
            }
        }
        

       
    }
    


}
