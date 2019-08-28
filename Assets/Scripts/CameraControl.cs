using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    Camera mainCamera;
    public float turnCameraSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        mainCamera.transform.position += new Vector3(turnCameraSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0);
    }
}
