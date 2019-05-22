using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    Transform carTransform;
    [Range(0, 10)]
    public float turnSpeed = 2;
    [Range(0, 10)]
    public float upSpeed = 2;

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
        }
        else if (carTransform.position.z > -5.5) carTransform.position -= new Vector3(0, 0, Time.deltaTime * upSpeed);

    }

}
