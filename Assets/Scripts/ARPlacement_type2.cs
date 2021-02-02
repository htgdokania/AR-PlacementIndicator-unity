using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


public class ARPlacement_type2 : MonoBehaviour
{

    private ARRaycastManager rayManager;
    private GameObject visual;

    void Start()
    {
        //get the components
        rayManager = FindObjectOfType<ARRaycastManager>();
        visual = transform.GetChild(0).gameObject;

        //hide the placement indicator visual
        visual.SetActive(false);
    }

    void Update()
    {
        //shoot a raycast from centre of the screen
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        rayManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, TrackableType.Planes);

        //if we hit  an AR plane, update position and rotation
        if(hits.Count > 0 )
        {
            transform.position = hits[0].pose.position;
            transform.rotation = hits[0].pose.rotation;

            if(!visual.activeInHierarchy)
                visual.SetActive(true);
        }

    }
}
