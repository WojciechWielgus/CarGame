using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    /*
    public GameObject enemy_prefab;
    GameObject enemy;
    private GameObject[] enemys = new GameObject[100];
    bool[] enemys_live = new bool[100];

    [Range(1, 20)]
    public float enemy_speed = 1.0f;

    float[] lines = new float[] { -3.3f, -1.1f, 1.1f, 3.3f };

    private void Start()
    {
        enemys_live[0] = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            enemys[0] = Instantiate(enemy_prefab, new Vector3(lines[Random.Range(0, 3)], 0.3f, GetComponent<Transform>().position.z), Quaternion.identity);
            enemys_live[0] = true;
        }
        if (enemys_live[0])
        {
            if (enemys[0].transform.position.z < -10)
            {
                enemys_live[0] = false;
                Destroy(enemys[0]);
            }
            enemys[0].transform.position += new Vector3(0, 0, -enemy_speed * Time.deltaTime);
        }
    }
    */
    
    public GameObject enemyPrefab;
    float[] lines = new float[] { -3.3f, -1.1f, 1.1f, 3.3f };


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(enemyPrefab, new Vector3(lines[Random.Range(0, 3)], 0.3f, GetComponent<Transform>().position.z), Quaternion.identity);
        }

        Debug.Log("spawenemy");
    }
    


}
