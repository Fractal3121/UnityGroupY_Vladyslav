using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneScript : MonoBehaviour
{
    float movamentSpeed = 3;
    int turningSpeed = 55;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W)) transform.position += movamentSpeed * transform.forward * Time.deltaTime;
        //ROTATION
        if (Input.GetKey(KeyCode.E)) transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.Q)) transform.Rotate(Vector3.up, -turningSpeed * Time.deltaTime);
        //
        if (Input.GetKey(KeyCode.Space)) transform.Rotate(Vector3.left, turningSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.C)) transform.Rotate(Vector3.left, -turningSpeed * Time.deltaTime);
        //
        if (Input.GetKey(KeyCode.A)) transform.Rotate(Vector3.forward, turningSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D)) transform.Rotate(Vector3.forward, -turningSpeed * Time.deltaTime);
    }
}
