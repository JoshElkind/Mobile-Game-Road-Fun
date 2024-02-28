using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    
    public GameObject controller;

    private int car_count = 1;
    
    public GameObject Ramp;
    public GameObject Gold_Coin;
    public GameObject Chest;
    public GameObject Speed_Limit_110;
    public GameObject Barrier_Stone;
    public GameObject Kangaroo_Sign;
    public GameObject Orange_Large_Cone;
    public GameObject Pyramid_Stone_Barrier;
    public GameObject Red_Stripe_Warning_Sign;
    public GameObject Red_White_Sign;
    public GameObject Stop_Sign;
    public GameObject Traffic_Light_Pole;

    private List<GameObject> badItem;
    


    private List<GameObject> goodItem;


    public GameObject Blue_Sedan;
    public GameObject Cyber_Car;
    public GameObject Dodge;
    public GameObject Red_Chevy;
    public GameObject Red_F1;
    public GameObject Yellow_GTR;

    private List<GameObject> spawnCar;

    private List<GameObject> commonCars;

    private List<GameObject> rareCars;

    private List<GameObject> epicCars;  

    private List<int> available_lane;

    Transform veh1position;
    Transform veh2position;
    Transform veh3position;



    private int Random_Int;
    private int Ran_Car;
    private int Ran_Nest;
    private int Random_Lane;
    private float Random_Z;

    private int Obstacle_Lane;
    private int Bad_Good;
    private int Which;
    int Lane;

    string difficulty;

    public GameObject obstacle_spawn;
    public Transform obstacletran;

    float y_cor;
    List<float> x_cor;

    GameObject veh1;
    GameObject veh2;
    GameObject veh3;
    // Start is called before the first frame update
    void Start()
    {
        spawnCar = new List<GameObject>();
        x_cor = new List<float>();
        badItem = new List<GameObject>();
        badItem.Add(Speed_Limit_110);
        badItem.Add(Barrier_Stone);
        badItem.Add(Kangaroo_Sign);
        badItem.Add(Orange_Large_Cone);
        badItem.Add(Pyramid_Stone_Barrier);
        badItem.Add(Red_Stripe_Warning_Sign);
        badItem.Add(Red_White_Sign);
        badItem.Add(Stop_Sign);
        badItem.Add(Traffic_Light_Pole);


        goodItem = new List<GameObject>();
        goodItem.Add(Ramp);
        goodItem.Add(Gold_Coin);
        goodItem.Add(Chest);


        commonCars = new List<GameObject>();
        commonCars.Add(Blue_Sedan);
        commonCars.Add(Red_Chevy);


        rareCars = new List<GameObject>();
        commonCars.Add(Dodge);
        commonCars.Add(Yellow_GTR);


        epicCars = new List<GameObject>();
        commonCars.Add(Red_F1);
        commonCars.Add(Cyber_Car);  


        available_lane = new List<int>();
        available_lane.Add( 1);
        available_lane.Add( 2);
        available_lane.Add( 3);
        available_lane.Add( 4);
        Debug.Log(available_lane);
        
    
        controller = GameObject.Find("GameControl");
        difficulty = controller.GetComponent<GameController>().difficulty;
        
        if (difficulty == "easy" && gameObject.transform.parent.name != "road") {
            Debug.Log(gameObject.transform.parent.name + "            1");
            Bad_Good = Random.Range(1,5);
            if (Bad_Good == 2) {
                goodItem.Add(Gold_Coin);
                goodItem.Add(Gold_Coin);
                Which = Random.Range(0,goodItem.Count);
                obstacle_spawn = Instantiate(goodItem[Which]);
                Debug.Log(goodItem[Which].name);
                obstacle_spawn.name = goodItem[Which].name;
                Random_Lane = Random.Range(1,5);
                obstacletran = obstacle_spawn.GetComponent<Transform>();
                obstacletran.transform.parent = gameObject.transform.parent.gameObject.transform.GetChild(6).transform;
                Random_Z = Random.Range(0,81);
                Random_Z = Random_Z - 40;
                
                if (goodItem[Which].name == "Ramp") {
                    y_cor = -4.01F;
                    x_cor.Add(10.74F);
                    x_cor.Add(3.72F);
                    x_cor.Add(-3.29F);
                    x_cor.Add(-10.56F);
                }

                else if (goodItem[Which].name == "Gold Coin") {
                    y_cor = 5.64F;
                    x_cor.Add(23.25F);
                    x_cor.Add(16.32F);
                    x_cor.Add(9.51F);
                    x_cor.Add(1.82F);
                }

                else if (goodItem[Which].name == "Chest") {
                    y_cor = 1.19F;
                    x_cor.Add(10.8F);
                    x_cor.Add(3.43F);
                    x_cor.Add(-3.64F);
                    x_cor.Add(-10.7F);
                }

                else {
                    y_cor = 1.19F;
                    x_cor.Add(10.8F);
                    x_cor.Add(3.43F);
                    x_cor.Add(-3.64F);
                    x_cor.Add(-10.7F);
                }
                
                if (Random_Lane == 1) {
                   obstacle_spawn.transform.localPosition  = new Vector3(x_cor[Random_Lane-1], y_cor, Random_Z);
                   
                }
                if (Random_Lane == 2) {
                   obstacle_spawn.transform.localPosition  = new Vector3(x_cor[Random_Lane-1], y_cor, Random_Z);
                   
                }
                if (Random_Lane == 3) {
                   obstacle_spawn.transform.localPosition  = new Vector3(x_cor[Random_Lane-1], y_cor, Random_Z);
                   
                }
                if (Random_Lane == 4) {
                   obstacle_spawn.transform.localPosition   = new Vector3(x_cor[Random_Lane-1], y_cor, Random_Z);
                   
                }



            }

            else {
                Debug.Log(gameObject.transform.parent.name + "|");
                Which = Random.Range(0,badItem.Count);
                Debug.Log(gameObject.transform.parent.name + "||");
                obstacle_spawn = Instantiate(badItem[Which]);
                Debug.Log(gameObject.transform.parent.name + "|||");
                Random_Lane = Random.Range(1,5);
                Debug.Log(gameObject.transform.parent.name + "||||");
                obstacletran = obstacle_spawn.GetComponent<Transform>();
                Debug.Log(gameObject.transform.parent.name + "|||||");
                obstacletran.transform.parent = gameObject.transform.parent.gameObject.transform.GetChild(6).transform;
                Debug.Log(gameObject.transform.parent.name + "||||||");
                Random_Z = Random.Range(0,81);
                Random_Z = Random_Z - 40;
                Debug.Log(gameObject.transform.parent.name + "||||||||");
                if (Random_Lane == 1) {
              
                   obstacletran.transform.localPosition  = new Vector3(11.22F, 0, Random_Z);
                   
                }
                if (Random_Lane == 2) {
             
                   obstacletran.transform.localPosition  = new Vector3(3.48F, 0, Random_Z);
                   
                }
                if (Random_Lane == 3) {
                 
                   obstacletran.transform.localPosition  = new Vector3(-3.11F, 0, Random_Z);
                   
                }
                if (Random_Lane == 4) {
                   
                   obstacletran.transform.localPosition   = new Vector3(-10.93F, 0, Random_Z);
                   
                }
            }
            Debug.Log(gameObject.transform.parent.name + "                2");
            car_count = 1;
            Random_Int = Random.Range(1,20);
            if (Random_Int == 1) {
                Ran_Car = Random.Range(0,rareCars.Count);
                spawnCar.Add(rareCars[Ran_Car]);
                Debug.Log(gameObject.transform.parent.name + "                fortnite");

            }
            else {
                Ran_Car = Random.Range(0,commonCars.Count);
                spawnCar.Add(commonCars[Ran_Car]);
            }
            Debug.Log(gameObject.transform.parent.name + "                poop");
            veh1 = Instantiate(spawnCar[0]) as GameObject;
            
            Debug.Log(spawnCar[0].name + "       " + gameObject.transform.parent.name);
            
            
            
            veh1position = veh1.GetComponent<Transform>();
            veh1position.transform.parent = gameObject.transform.parent.gameObject.transform.GetChild(6).transform;
            Random_Lane = Random.Range(0,available_lane.Count);
            Lane = available_lane[Random_Lane];
            available_lane.Remove(Lane);
            
            Random_Z = Random.Range(0,740);
            Random_Z = (Random_Z - 370)/10;

            if (Lane == 1) {
                   veh1.transform.localPosition  = new Vector3(10.95F, 0, Random_Z);
                   Debug.Log(veh1.transform.localPosition );
                   
                }
            if (Lane == 2) {
                   veh1.transform.localPosition  = new Vector3(3.81F, 0, Random_Z);
                   Debug.Log(veh1.transform.localPosition);
                   
                }
            if (Lane == 3) {
                   veh1.transform.localPosition  = new Vector3(-3.46F, 0, Random_Z);
                   Debug.Log(veh1.transform.localPosition);
                  
                }
            if (Lane == 4) {
                   veh1.transform.localPosition  = new Vector3(-0.35F,0, Random_Z);
                   Debug.Log(veh1.transform.localPosition);
                   
                }

        }

        else if (difficulty == "medium" && gameObject.transform.parent.name != "road") {
            Bad_Good = Random.Range(1,4);
            if (Bad_Good == 2) {
                goodItem.Add(Gold_Coin);
                Which = Random.Range(0,goodItem.Count);
                obstacle_spawn = Instantiate(goodItem[Which]);
                Random_Lane = Random.Range(1,5);
                obstacletran = obstacle_spawn.GetComponent<Transform>();
                obstacletran.transform.parent = gameObject.transform.parent.gameObject.transform.GetChild(6).transform;
                obstacletran = obstacle_spawn.GetComponent<Transform>();
                Random_Z = Random.Range(0,740);
                
                Random_Z = (Random_Z - 370)/10;
                
                
                if (Random_Lane == 1) {
              
                   obstacletran.transform.localPosition  = new Vector3(11.22F, 0, Random_Z);
                   
                }
                if (Random_Lane == 2) {
             
                   obstacletran.transform.localPosition  = new Vector3(3.48F, 0, Random_Z);
                   
                }
                if (Random_Lane == 3) {
                 
                   obstacletran.transform.localPosition  = new Vector3(-3.11F, 0, Random_Z);
                   
                }
                if (Random_Lane == 4) {
                   
                   obstacletran.transform.localPosition   = new Vector3(-10.93F, 0, Random_Z);
                   
                }



            }

            else {
                Which = Random.Range(0,badItem.Count);
                obstacle_spawn = Instantiate(badItem[Which]);
                Random_Lane = Random.Range(1,5);
                obstacletran = obstacle_spawn.GetComponent<Transform>();
                obstacletran.transform.parent = gameObject.transform.parent.gameObject.transform.GetChild(6).transform;
                Random_Z = Random.Range(0,81);
                Random_Z = Random_Z - 40;
                if (Random_Lane == 1) {
              
                   obstacletran.transform.localPosition  = new Vector3(11.22F, 0, Random_Z);
                   
                }
                if (Random_Lane == 2) {
             
                   obstacletran.transform.localPosition  = new Vector3(3.48F, 0, Random_Z);
                   
                }
                if (Random_Lane == 3) {
                 
                   obstacletran.transform.localPosition  = new Vector3(-3.11F, 0, Random_Z);
                   
                }
                if (Random_Lane == 4) {
                   
                   obstacletran.transform.localPosition   = new Vector3(-10.93F, 0, Random_Z);
                   
                }
            }

            
            car_count = 2;
            Random_Int = Random.Range(1,20);
            if (Random_Int == 1 || Random_Int == 2 || Random_Int == 3 || Random_Int == 4) {
                Ran_Nest = Random.Range(1,20);
                if (Ran_Nest == 1) {
                    Ran_Car = Random.Range(0,epicCars.Count);
                    spawnCar.Add(epicCars[Ran_Car]);
                }
                else {
                    Ran_Car = Random.Range(0,rareCars.Count);
                    spawnCar.Add(rareCars[Ran_Car]);
                }
                

            }
            else {
                Ran_Car = Random.Range(0,commonCars.Count);
                spawnCar.Add(commonCars[Ran_Car]);
            }

            //2nd
            Random_Int = Random.Range(1,20);

            if (Random_Int == 1 || Random_Int == 2 || Random_Int == 3 || Random_Int == 4) {
                Ran_Nest = Random.Range(1,20);
                if (Ran_Nest == 1) {
                    Ran_Car = Random.Range(0,epicCars.Count);
                    spawnCar.Add(epicCars[Ran_Car]);
                }
                else {
                    Ran_Car = Random.Range(0,rareCars.Count);
                    spawnCar.Add(rareCars[Ran_Car]);
                }
                

            }
            else {
                Ran_Car = Random.Range(0,commonCars.Count);
                spawnCar.Add(commonCars[Ran_Car]);
            }
            veh1 = Instantiate(spawnCar[0]) as GameObject;
            Debug.Log(spawnCar[0].name + "medium 1");
            
            veh1position = veh1.GetComponent<Transform>();
            veh1position.transform.parent = gameObject.transform.parent.gameObject.transform.GetChild(6).transform;
            Random_Lane = Random.Range(0,available_lane.Count);
            Lane = available_lane[Random_Lane];
            available_lane.Remove(Lane);
            Random_Z = Random.Range(0,740);
            Random_Z = (Random_Z - 370)/10;
            if (Lane == 1) {
                   veh1.transform.localPosition  = new Vector3(10.95F, 0, Random_Z);
                   
                }
            if (Lane == 2) {
                   veh1.transform.localPosition  = new Vector3(3.81F, 0, Random_Z);
                   
                }
            if (Lane == 3) {
                   veh1.transform.localPosition  = new Vector3(-3.46F, 0, Random_Z);
                   
                }
            if (Lane == 4) {
                   veh1.transform.localPosition  = new Vector3(-0.35F, 0, Random_Z);
                
                }
            veh2 = Instantiate(spawnCar[1]) as GameObject;
            Debug.Log(spawnCar[1].name + "medium 2");
            
            veh2position = veh2.GetComponent<Transform>();
            veh2position.transform.parent = gameObject.transform.parent.gameObject.transform.GetChild(6).transform;
            Random_Lane = Random.Range(0,available_lane.Count);
            Lane = available_lane[Random_Lane];
            available_lane.Remove(Lane);
            Random_Z = Random.Range(0,740);
            Random_Z = (Random_Z - 370)/10;
            if (Lane == 1) {
                   veh2.transform.localPosition  = new Vector3(10.95F,0, Random_Z);
                   
                }
            if (Lane == 2) {
                   veh2.transform.localPosition  = new Vector3(3.81F,0, Random_Z);
                   
                }
            if (Lane == 3) {
                   veh2.transform.localPosition  = new Vector3(-3.46F, 0, Random_Z);
                   
                }
            if (Lane == 4) {
                   veh2.transform.localPosition   = new Vector3(-0.35F, 0, Random_Z);
                   
                }
            
        }

        else if (difficulty == "hard" && gameObject.transform.parent.name != "road") {
            Bad_Good = Random.Range(1,3);
            if (Bad_Good == 2) {
                goodItem.Add(Chest);
                Which = Random.Range(0,goodItem.Count);
                obstacle_spawn = Instantiate(goodItem[Which]);
                Random_Lane = Random.Range(1,5);
                obstacletran = obstacle_spawn.GetComponent<Transform>();
                obstacletran.transform.parent = gameObject.transform.parent.gameObject.transform.GetChild(6).transform;
                obstacletran = obstacle_spawn.GetComponent<Transform>();
                Random_Z = Random.Range(0,740);
                
                Random_Z = (Random_Z - 370)/10;
                
                
                if (Random_Lane == 1) {
              
                   obstacletran.transform.localPosition  = new Vector3(11.22F, 0, Random_Z);
                   
                }
                if (Random_Lane == 2) {
             
                   obstacletran.transform.localPosition  = new Vector3(3.48F, 0, Random_Z);
                   
                }
                if (Random_Lane == 3) {
                 
                   obstacletran.transform.localPosition  = new Vector3(-3.11F, 0, Random_Z);
                   
                }
                if (Random_Lane == 4) {
                   
                   obstacletran.transform.localPosition   = new Vector3(-10.93F, 0, Random_Z);
                   
                }
                /*
                Random_Lane = Random.Range(1,5);
                obstacletran = obstacle_spawn.GetComponent<Transform>();
                obstacletran.transform.parent = gameObject.transform.parent.gameObject.transform.GetChild(6).transform;
                Random_Z = Random.Range(0,740);
                Random_Z = (Random_Z - 370)/10;
                
                if (goodItem[Which] == Ramp) {
                    y_cor = -4.01F;
                    x_cor.Add(10.74F);
                    x_cor.Add(3.72F);
                    x_cor.Add(-3.29F);
                    x_cor.Add(-10.56F);
                }

                else if (goodItem[Which] == Gold_Coin) {
                    y_cor = 5.64F;
                    x_cor.Add(23.25F);
                    x_cor.Add(16.32F);
                    x_cor.Add(9.51F);
                    x_cor.Add(1.82F);
                }

                else if (goodItem[Which] == Chest) {
                    y_cor = 1.19F;
                    x_cor.Add(10.8F);
                    x_cor.Add(3.43F);
                    x_cor.Add(-3.64F);
                    x_cor.Add(-10.7F);
                }

                else {
                    y_cor = 0;
                }
                
                if (Random_Lane == 1) {
                   obstacle_spawn.transform.localPosition  = new Vector3(x_cor[Random_Lane-1], y_cor, Random_Z);
                   
                }
                if (Random_Lane == 2) {
                   obstacle_spawn.transform.localPosition  = new Vector3(x_cor[Random_Lane-1], y_cor, Random_Z);
                   
                }
                if (Random_Lane == 3) {
                   obstacle_spawn.transform.localPosition  = new Vector3(x_cor[Random_Lane-1], y_cor, Random_Z);
                   
                }
                if (Random_Lane == 4) {
                   obstacle_spawn.transform.localPosition   = new Vector3(x_cor[Random_Lane-1], y_cor, Random_Z);
                   
                }
                */



            }

            else {
                Which = Random.Range(0,badItem.Count);
                obstacle_spawn = Instantiate(badItem[Which]);
                Random_Lane = Random.Range(1,5);
                obstacletran = obstacle_spawn.GetComponent<Transform>();
                obstacletran.transform.parent = gameObject.transform.parent.gameObject.transform.GetChild(6).transform;
                Random_Z = Random.Range(0,81);
                Random_Z = Random_Z - 40;
                if (Random_Lane == 1) {
              
                   obstacletran.transform.localPosition  = new Vector3(11.22F, 0, Random_Z);
                   
                }
                if (Random_Lane == 2) {
             
                   obstacletran.transform.localPosition  = new Vector3(3.48F, 0, Random_Z);
                   
                }
                if (Random_Lane == 3) {
                 
                   obstacletran.transform.localPosition  = new Vector3(-3.11F, 0, Random_Z);
                   
                }
                if (Random_Lane == 4) {
                   
                   obstacletran.transform.localPosition   = new Vector3(-10.93F, 0, Random_Z);
                   
                }
            }
            car_count = 3;
            Random_Int = Random.Range(1,2);
            if (Random_Int == 1) {
                Ran_Nest = Random.Range(1,10);
                if (Ran_Nest == 1) {
                    Ran_Car = Random.Range(0,epicCars.Count);
                    spawnCar.Add(epicCars[Ran_Car]);
                }
                else {
                    Ran_Car = Random.Range(0,rareCars.Count);
                    spawnCar.Add(rareCars[Ran_Car]);
                }
            }
            else {
                Ran_Car = Random.Range(0,commonCars.Count);
                spawnCar.Add(commonCars[Ran_Car]);
            }
            //2nd
            Random_Int = Random.Range(1,2);
            if (Random_Int == 1) {
                Ran_Nest = Random.Range(1,10);
                if (Ran_Nest == 1) {
                    Ran_Car = Random.Range(0,epicCars.Count);
                    spawnCar.Add(epicCars[Ran_Car]);
                }
                else {
                    Ran_Car = Random.Range(0,rareCars.Count);
                    spawnCar.Add(rareCars[Ran_Car]);
                }
            }
            else {
                Ran_Car = Random.Range(0,commonCars.Count);
                spawnCar.Add(commonCars[Ran_Car]);
            }
            //3rd
            Random_Int = Random.Range(1,2);
            if (Random_Int == 1) {
                Ran_Nest = Random.Range(1,10);
                if (Ran_Nest == 1) {
                    Ran_Car = Random.Range(0,epicCars.Count);
                    spawnCar.Add(epicCars[Ran_Car]);
                }
                else {
                    Ran_Car = Random.Range(0,rareCars.Count);
                    spawnCar.Add(rareCars[Ran_Car]);
                }
            }
            else {
                Ran_Car = Random.Range(0,commonCars.Count);
                spawnCar.Add(commonCars[Ran_Car]);
            }
           
            veh1 = Instantiate(spawnCar[0]) as GameObject;
            Debug.Log(spawnCar[0].name + "hard 1");
           
            veh1position.transform.parent = gameObject.transform.parent.gameObject.transform.GetChild(6).transform;
            Random_Lane = Random.Range(0,available_lane.Count);
            Lane = available_lane[Random_Lane];
            available_lane.Remove(Lane);
            Random_Z = Random.Range(0,740);
            Random_Z = (Random_Z - 370)/10;
            if (Lane == 1) {
                   veh1.transform.localPosition  = new Vector3(10.95F, 0, Random_Z);
                   
                }
            if (Lane == 2) {
                   veh1.transform.localPosition  = new Vector3(3.81F, 0, Random_Z);
                   
                }
            if (Lane == 3) {
                   veh1.transform.localPosition  = new Vector3(-3.46F, 0, Random_Z);
                   
                }
            if (Lane == 4) {
                   veh1.transform.localPosition  = new Vector3(-0.35F, 0, Random_Z);
                
                }
            veh2 = Instantiate(spawnCar[1]) as GameObject;
            Debug.Log(spawnCar[1].name + "hard 2");
            
            veh2position = veh2.GetComponent<Transform>();
            veh2position.transform.parent = gameObject.transform.parent.gameObject.transform.GetChild(6).transform;
            Random_Lane = Random.Range(0,available_lane.Count);
            Lane = available_lane[Random_Lane];
            available_lane.Remove(Lane);
            Random_Z = Random.Range(0,740);
            Random_Z = (Random_Z - 370)/10;
            if (Lane == 1) {
                   veh2.transform.localPosition  = new Vector3(10.95F, 0, Random_Z);
                   
                }
            if (Lane == 2) {
                   veh2.transform.localPosition  = new Vector3(3.81F, 0, Random_Z);
                   
                }
            if (Lane == 3) {
                   veh2.transform.localPosition  = new Vector3(-3.46F,0 , Random_Z);
                   
                }
            if (Lane == 4) {
                   veh2.transform.localPosition  = new Vector3(-0.35F, 0, Random_Z);
                
                }
            veh3 = Instantiate(spawnCar[2]) as GameObject;
            Debug.Log(spawnCar[2].name + "hard 3");
            
            veh3position = veh3.GetComponent<Transform>();
            veh3position.transform.parent = gameObject.transform.parent.gameObject.transform.GetChild(6).transform;
            Random_Lane = Random.Range(0,available_lane.Count);
            Lane = available_lane[Random_Lane];
            available_lane.Remove(Lane);
            Random_Z = Random.Range(0,740);
            Random_Z = (Random_Z - 370)/10;
            
            if (Lane == 1) {
                   veh3.transform.localPosition  = new Vector3(10.95F, 0, Random_Z);
                   
                }
            if (Lane == 2) {
                   veh3.transform.localPosition  = new Vector3(3.81F, 0, Random_Z);
                   
                }
            if (Lane == 3) {
                   veh3.transform.localPosition  = new Vector3(-3.46F, 0, Random_Z);
                   
                }
            if (Lane == 4) {
                   veh3.transform.localPosition  = new Vector3(-0.35F, 0, Random_Z);
                
                }
        
    
        }




        }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}