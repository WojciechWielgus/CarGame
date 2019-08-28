using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Unit
{

    bool enemy_live = false;

    
    float enemy_speed = 7.0f;

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
            }
            GetComponent<Transform>().position += new Vector3(0, 0, -enemy_speed * Time.deltaTime * (speed/25));
        }
    }
}
