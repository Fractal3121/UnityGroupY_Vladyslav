using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myHeroScript : MonoBehaviour
{
    float runningSpeed = 3;
    int turningSpeed = 55;
    // Start is called before the first frame update
    void Start()
    {
        transform.position += new Vector3(0,1,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) transform.position += new Vector3(0, 1, 0)*Time.deltaTime;
        if (Input.GetKey(KeyCode.A)) transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
        if (Input.GetKey(KeyCode.C)) transform.position += new Vector3(0, -1, 0) * Time.deltaTime;
        if (Input.GetKey(KeyCode.D)) transform.position += new Vector3(-1, 0, 0) * Time.deltaTime;
        if (Input.GetKey(KeyCode.W)) transform.position += runningSpeed*transform.forward * Time.deltaTime;
        if (Input.GetKey(KeyCode.S)) transform.position -= runningSpeed * transform.forward * Time.deltaTime;
        //ROTATION
        if (Input.GetKey(KeyCode.E)) transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.Q)) transform.Rotate(Vector3.up, -turningSpeed * Time.deltaTime);
    }
}
