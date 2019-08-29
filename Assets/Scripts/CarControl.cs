using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CarControl : Unit
{
    Transform carTransform;
    [Range(0, 10)]
    public float turnBoost = 2f;
    [Range(0, 10)]
    public float upSpeed = 2f;
    [Range(5, 50)]
    public float acceleration = 10f;
    public float max_speed = 120.0f;
    public float min_speed = 40.0f;

    private float turnSpeed;

    float distance = 0f;

    public Text text_speed;
    public Text text_distance;

    private Camera playercamera;

    private void Start()
    {
        carTransform = GetComponent<Transform>();
        playercamera = GetComponentInChildren<Camera>();
        speed = min_speed;
    }

    private void Update()
    {
        if (speed < min_speed) speed = min_speed;
        TurnSpeed = turnBoost * Time.deltaTime * ((speed + 10) / 10);
        carTransform.position += new Vector3(TurnSpeed * Input.GetAxis("Horizontal"), 0, 0);
        
        
        if (Input.GetAxis("Vertical") > 0)
        {
            if (playercamera.transform.position.z > -12.0) playercamera.transform.position -= new Vector3(0, 0, Time.deltaTime * upSpeed);
            speed += Time.deltaTime * acceleration;
        }
        

        if (Input.GetAxis("Vertical") < 0)
        {
            if (playercamera.transform.position.z < -8.5) playercamera.transform.position += new Vector3(0, 0, Time.deltaTime * upSpeed);
            speed -= Time.deltaTime * acceleration;
        }

        

        if (speed > max_speed) speed = max_speed;
        text_speed.text = System.Math.Round(speed, 2) + " km/h";

        distance += Time.deltaTime * speed;
        text_distance.text = System.Math.Round(distance/2, 2) + " m";

        

        



    }

    

    
}
