using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    bool enemy_live = false;

    [Range(1, 20)]
    public float enemy_speed = 1.0f;

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
            GetComponent<Transform>().position += new Vector3(0, 0, -enemy_speed * Time.deltaTime);
        }
    }
}
