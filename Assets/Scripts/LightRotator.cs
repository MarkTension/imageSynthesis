using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRotator : MonoBehaviour
{
    void Start()
    {
        //transform.rotation = Random.rotation;
        /*float newX, newY, newZ;
        newX = Random.Range(30.0f, 150.0f);
        newY = Random.Range(-60.0f, 60.0f);
        newZ = Random.Range(-60.0f, 60.0f);
        Quaternion newRot = new Quaternion(newX, newY, newZ, 1);
        transform.rotation = newRot;
    } */
        
    }

    void Update()
    {
        float newX, newY, newZ;
        newX = Random.Range(-0.5f, 0.5f);
        newY = Random.Range(-2f, 2f);
        newZ = Random.Range(-2f, 2f);
        transform.Rotate(newX, newY, newZ, Space.Self);
    }

}
