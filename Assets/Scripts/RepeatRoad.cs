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

    public GameObject BackgroundPrefab;
    public float backgroundSpeed = 3.0f;
    Vector3 BackgroundCreateCoortinates = new Vector3(0,-0.001f, 20);
    private GameObject Background;
    private int backgroundCount = 1;

    private void Start()
    {
        Background = Instantiate(BackgroundPrefab, new Vector3(0, -0.001f, 0), BackgroundPrefab.transform.rotation);

    }

    private void Update()
    {


        if (Input.GetAxis("Vertical") > 0)
        {
            multiply = boost_multipler;
        } else multiply = 1;
        offset = new Vector2(0, Time.time * speed * multiply);
        GetComponent<Renderer>().material.mainTextureOffset = offset;

        Background.transform.position -= new Vector3(0, 0, Time.deltaTime * backgroundSpeed * multiply);
        if (Background.transform.position.z < -20 && backgroundCount < 2)
        {
            Background.transform.position += new Vector3(0, 0, 20);
        }
    }
}
