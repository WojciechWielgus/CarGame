using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatRoad : MonoBehaviour
{
    public float speed = 0.5f;
    Vector2 offset;
    [Range(0,3)]
    public float boost_multipler = 2;
    public float multiply = 1;

    private void Update()
    {
        if (Input.GetAxis("Vertical") > 0) multiply = boost_multipler; else multiply = 1;
        offset = new Vector2(0, Time.time * speed * multiply);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
