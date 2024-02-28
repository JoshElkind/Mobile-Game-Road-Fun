using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float offset = 9.7F;
    public GameObject Car;
    // Start is called before the first frame update
    void Start()
    {
        Car = GameObject.Find("Car"); 
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, ((Car.transform.position.z) + (offset)));
    }
}
