using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class explodeScript : MonoBehaviour
{
    Rigidbody rb;
    float explosionRad = 10;
    float explosionStrength = 2000;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(45*transform.forward, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Collider[] allVictimcolider = Physics.OverlapSphere(transform.position, explosionRad);
            foreach (Collider collider in allVictimcolider)
            {
                Rigidbody rigidbody = collider.GetComponent<Rigidbody>();
                if (rigidbody != null){
                    rigidbody.AddExplosionForce(explosionStrength, transform.position, explosionRad);
                }
            }
            Destroy(gameObject);
    }
}   

