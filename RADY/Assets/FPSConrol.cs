using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FPSConrol : MonoBehaviour
{   float speed = 3;
    int rotAngle = 55;

    public GameObject bulletCloneTemplate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 fpsMovementDirection = new Vector3(transform.forward.x, 0 , transform.forward.z);
            fpsMovementDirection.Normalize();
            transform.position += speed * fpsMovementDirection * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 fpsMovementDirection = new Vector3(transform.forward.x, 0, transform.forward.z);
            fpsMovementDirection.Normalize();
            transform.position -= speed * fpsMovementDirection * Time.deltaTime;
        }
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal"), Space.World);
        transform.Rotate(transform.right, Input.GetAxis("Vertical"), Space.World);

        if (Input.GetMouseButtonDown(0)) 
        {
            Instantiate(bulletCloneTemplate, transform.position, transform.rotation);
        }
        if (Input.GetKey(KeyCode.C)) transform.position += new Vector3(0, -1, 0) * Time.deltaTime;
        if (Input.GetKey(KeyCode.Space)) transform.position += new Vector3(0, 1, 0) * Time.deltaTime;
        if (Input.GetKey(KeyCode.A)) transform.position -= speed * transform.right * Time.deltaTime;
        if (Input.GetKey(KeyCode.D)) transform.position += speed * transform.right * Time.deltaTime;

    }
}
