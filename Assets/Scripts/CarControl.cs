using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CarControl : Unit
{
    Transform carTransform;
    [Range(0, 10)]
    public float turnSpeed = 2f;
    [Range(0, 10)]
    public float upSpeed = 2f;
    [Range(5, 50)]
    public float acceleration = 10f;
    public float max_speed = 120.0f;


    float distance = 0f;

    public Text text_speed;
    public Text text_distance;

    private void Start()
    {
        carTransform = GetComponent<Transform>();
    }

    private void Update()
    {
         
        carTransform.position += new Vector3(turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0);
        
        if (Input.GetAxis("Vertical") > 0)
        {
            if (carTransform.position.z < -4.5) carTransform.position += new Vector3(0, 0, Time.deltaTime * upSpeed);
            speed += Time.deltaTime * acceleration;
        }
        else if (carTransform.position.z > -5.5) carTransform.position -= new Vector3(0, 0, Time.deltaTime * upSpeed);

        if (Input.GetAxis("Vertical") < 0)
        {
            speed -= Time.deltaTime * acceleration;
        }

        

        if (speed > max_speed) speed = max_speed;
        text_speed.text = System.Math.Round(speed, 2) + " km/h";

        distance += Time.deltaTime * speed;
        text_distance.text = System.Math.Round(distance/2, 2) + " m";

        

        



    }

    

    
}
