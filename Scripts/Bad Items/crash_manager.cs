using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crash_manager : MonoBehaviour
{
    private Rigidbody rb;    
    public float thrust = 10090000.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
        
        if (other.gameObject.transform.parent.gameObject.transform.parent.name == "Car") {
            other.gameObject.transform.parent.gameObject.transform.parent.transform.position = new Vector3(-22505.2f, other.gameObject.transform.parent.gameObject.transform.parent.transform.position.y, other.gameObject.transform.parent.gameObject.transform.parent.transform.position.z);
        }
    }
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.transform.parent.gameObject.transform.parent.name == "Car") {
            other.gameObject.transform.parent.gameObject.transform.parent.transform.position = new Vector3(-22505.2f, other.gameObject.transform.parent.gameObject.transform.parent.transform.position.y, other.gameObject.transform.parent.gameObject.transform.parent.transform.position.z);
        }
    }
        
}
