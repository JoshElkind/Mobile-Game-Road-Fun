using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest_add : MonoBehaviour
{
    private GameObject coinCar;
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
        
        if (other.gameObject.transform.parent.gameObject.transform.parent.name == "Car") {
            coinCar = GameObject.Find("Car");
            Debug.Log(".");
            coinCar.GetComponent<CoinManager>().CoinCount += 100;
            Destroy(gameObject);
            }
        }
}

