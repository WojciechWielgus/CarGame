using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject Prefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Prefab, new Vector3(10, 10, 10), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
