using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Distance : MonoBehaviour
{
    Canvas canvas;
    Text text_distance;
    Text text_speed;

    public float speed = 30.0f; //in meters
    float distance = 0;
    



    private void Start()
    {
        canvas = GetComponent<Canvas>();
        text_distance = canvas.transform.Find("Distance").GetComponent<Text>();
        
        
    }

    private void Update()
    {
        
        distance += Time.deltaTime * speed; // in meters
        text_distance.text = "Distance: " + System.Math.Round(distance/1000, 2) + " km";


        //text_speed.text = speed * 3.6 + " km/h";

    }
}
