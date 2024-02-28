using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_car : MonoBehaviour
{
    private Rigidbody rb;   
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.TransformDirection(
        new Vector3(0, 0, 20));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.parent.gameObject.transform.parent.name == "Car") {
            // add coins to file.
        }
    }
}
