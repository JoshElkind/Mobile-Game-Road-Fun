using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class good_itemfloat : MonoBehaviour
{
    public float rotateSpeed;
    public float floatFrequency, floatAmplitude;
    public Vector3 startPos;

    void Start(){
        Invoke("CountTanksS", .5F);
    }

    void Update(){
        Invoke("CountTanksU", .6F);
    }

    void CountTanksU()
    {
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);

        Vector3 tempPos = startPos;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * floatFrequency) * floatAmplitude;

        transform.position = tempPos;
    }

    void CountTanksS()
    {
        startPos = transform.position;
    }
}
