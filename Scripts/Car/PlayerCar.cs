using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCar : MonoBehaviour
{
    public GameObject Car;
    public GameObject drivable;
    public float offset = 7.7F;
    // Start is called before the first frame update
    void Start()
    {
        
        drivable = Instantiate(Car) as GameObject;
        drivable.name = "Car";
        Transform carPos = drivable.GetComponent<Transform>();
        carPos.position = new Vector3(-22505.04F, 29687.98F, 14914.2F);
        drivable.AddComponent<CoinManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, ((drivable.transform.position.z) + (offset)));
   
    }
}
