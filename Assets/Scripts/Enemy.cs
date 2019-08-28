using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Unit
{

    bool enemy_live = false;

    
    float enemyMultiplySpeed = 0.5f;
    float enemySpeed = 0f;
    public float enemyMaxSpeed = 0.1f;

    private void Start()
    {
        enemy_live = true;
        
    }
    
    private void Update()
    {
        

        if (enemy_live)
        {
            if (GetComponent<Transform>().position.z < -10)
            {
                enemy_live = false;
                Destroy(gameObject);
                Unit.EnemyCount--;
            }

            if (enemySpeed < enemyMaxSpeed) enemySpeed = enemyMultiplySpeed * Time.deltaTime * speed; 
            else
            {
                enemySpeed = enemyMaxSpeed;
            }

            Debug.Log(enemySpeed);
            GetComponent<Transform>().position += new Vector3(0, 0, -enemySpeed);
            
        }
    }
}
