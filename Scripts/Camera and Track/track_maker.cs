using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class track_maker : MonoBehaviour
{
    
    private GameObject new_road;
    public GameObject controller;
    public GameObject spawn_road;
    public int controller_var;
    public string amount;
    private GameObject coinCar;
    public int speed;
    




   
    // Start is called before the first frame update
    void Start()
    {
        new_road = GameObject.Find("highway,dif 87.628").transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.transform.parent.transform.parent.name == "Car") 
        {
            Debug.Log("1");
            coinCar = GameObject.Find("Car");
            speed = 0;
            // speed equal velocity
            if (speed >= 1) {
                coinCar.GetComponent<CoinManager>().CoinCount += 1;
            }
            if (speed >= 25) {
                coinCar.GetComponent<CoinManager>().CoinCount += 1;
            }
            if (speed >= 50) {
                coinCar.GetComponent<CoinManager>().CoinCount += 1;
            }
            if (speed >= 75) {
                coinCar.GetComponent<CoinManager>().CoinCount += 1;
            }
            if (speed > 100) {
                coinCar.GetComponent<CoinManager>().CoinCount += 2;
            }
        
            
            
            controller = GameObject.Find("GameControl");
            controller.GetComponent<GameController>().Road_Count += 1;
            controller_var = controller.GetComponent<GameController>().Road_Count;
            //spawn_road.transform = new Vector3(spawn_road.transform.position.x, spawn_road.transform.position.y, -688.012 - (controller.GetComponent<GameController>().Road_Count)*87.628);
            //Debug.Log(spawn_road.transform.position);    
            spawn_road = Instantiate(new_road) as GameObject;
            
            Transform yourObject = spawn_road.GetComponent<Transform>();
            spawn_road.transform.parent = GameObject.Find("highway,dif 87.628").transform;
            yourObject = spawn_road.GetComponent<Transform>();
            yourObject.position = new Vector3(-22440.73F, 29386.32F, (14140.53F - (controller_var*87.628F)));
            amount = (controller_var+6).ToString();
            spawn_road.name = ("road (" + amount + ")");
        }


    }
}

