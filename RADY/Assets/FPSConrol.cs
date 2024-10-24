using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSConrol : MonoBehaviour
{   float speed = 3;
    int rotAngle = 55;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += speed * transform.forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= speed * transform.forward * Time.deltaTime;
        }
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal"));
        transform.Rotate(Vector3.right, Input.GetAxis("Vertical"));
    }
}
