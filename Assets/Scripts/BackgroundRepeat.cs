using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepeat : MonoBehaviour
{
    private Vector3 BackgroundPosition;
    private GameObject BackgroundPlate;
    // Start is called before the first frame update
    void Start()
    {
        BackgroundPlate = GetComponent<GameObject>();
        BackgroundPosition = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
