
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public static float speed { get; set; }
    public static float EnemyCount { get; set; }
    public static float TurnSpeed { get; set; }

    [SerializeField]
    public static bool GameIsRun = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

    }
}