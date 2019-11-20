using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRandomizer : MonoBehaviour
{
    private int frameCount = 0;

   
    void Start()
    {
        
    
    }


    void Update()
    {

        frameCount = frameCount + 1;
        if (frameCount % 5 == 0){
            // // Color
            float newR, newG, newB;
            newR = Random.Range(0.0f, 1.0f);
            newG = Random.Range(0.0f, 1.0f);
            newB = Random.Range(0.0f, 1.0f);
            var newColor = new Color(newR, newG, newB);
            GetComponent<Renderer>().material.color = newColor;

        }
    }
}
