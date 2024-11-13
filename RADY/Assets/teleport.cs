using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public GameObject trigger1;
    public GameObject trigger2;
    public GameObject point1;
    public GameObject point2;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
        
        if(collision.gameObject==trigger1){
            transform.position = point1.GetComponent<Transform>().position;
        }
        else if(collision.gameObject==trigger2){
            transform.position = point2.GetComponent<Transform>().position;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
