using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.IO;

public class SceneController : MonoBehaviour
{
    private ImageSynthesis _imageSynthesis;

    public GameObject[] prefabs;
    public int maxObjects = 1;

    private GameObject[] created;
    private int frameCount = 0;
    private int cycleCount = 0;

    void Start()
    {   
        var camera = GameObject.Find("Main Camera");
        _imageSynthesis = camera.GetComponent(typeof(ImageSynthesis)) as ImageSynthesis;
        created = new GameObject[maxObjects];
    }

    
    void Update()
    {

        if (frameCount % 5 == 0){
            GenerateRandom();
            // synth.OnSceneChange();
            // GetComponent<ImageSynthesis>().Save(frameCount);

            cycleCount = cycleCount + 1;

            string filename = $"image_{cycleCount.ToString().PadLeft(5, '0')}";

            _imageSynthesis.Save(filename, 256, 256, "captures2");
            cycleCount = cycleCount + 1;

        }

        if (cycleCount == 203){
            
            Debug.Log("end!");
            Debug.Log("end!");

        }

        frameCount = frameCount + 1;
    }


    void GenerateRandom()
    {
        for (int i = 0; i < created.Length; i++)
        {
            if (created[i] != null)
            {
                Destroy(created[i]);
            }
        
            // pick out a prefab
            int prefabIndx = Random.Range(0, prefabs.Length);
            GameObject prefab = prefabs[prefabIndx];

            // Position
            float newX, newZ;
            newX = Random.Range(-11.0f, 11.0f);
            newZ = Random.Range(-11.0f, 11.0f);
            Vector3 newPos = new Vector3(newX, 0, newZ);

            //Rotation
            var newObj = Instantiate(prefab, newPos, Quaternion.Euler(new Vector3(90, Random.Range(0, 360), 0)));
            created[i] = newObj; 
            

            //Scale
            float sx = Random.Range(8.0f, 11.0f);
            Vector3 newScale = new Vector3(sx, sx, sx);
            newObj.transform.localScale = newScale;

            // Color
            float newR, newG, newB;
            newR = Random.Range(0.0f, 1.0f);
            newG = Random.Range(0.0f, 1.0f);
            newB = Random.Range(0.0f, 1.0f);
            var newColor = new Color(newR, newG, newB);
            newObj.GetComponent<Renderer>().material.color = newColor;

            // Ratio
            float x = Random.Range(-7.0f, 7.0f);
            float y = Random.Range(-7.0f, 7.0f);
            float z = Random.Range(-7.0f, 7.0f);
            newObj.transform.localScale += new Vector3(x, y, z);

        }
    }
}
