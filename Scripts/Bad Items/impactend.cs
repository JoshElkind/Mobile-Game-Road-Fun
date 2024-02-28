using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impactend : MonoBehaviour
{
    public float x_bad1;
    public float x_bad2;
    public float x_bad3;
    public float x_bad4;

    public float y_bad;
    
    public float z_start;
    public float z_end;
    
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
            //add coins to game file
            Application.Quit();
        }
    }
}
