using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_add : MonoBehaviour

{
    private GameObject coinCar;
    public GameObject CoinParent;

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
            coinCar.GetComponent<CoinManager>().CoinCount += 25;
            
            Destroy(gameObject);
            }
        }
    }

