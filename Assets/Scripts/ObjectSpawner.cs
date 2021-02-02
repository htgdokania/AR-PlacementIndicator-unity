using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objecttospawn;
    private ARPlacement_type2 placementIndicator;
    
    void start()
    {
        placementIndicator = FindObjectOfType<ARPlacement_type2>();
    }
    void update()
    {
        if(Input.touchCount >0 && Input.touches[0].phase == TouchPhase.Began)
        {
            GameObject obj = Instantiate(objecttospawn, placementIndicator.transform.position, placementIndicator.transform.rotation);
        }
    }

}
