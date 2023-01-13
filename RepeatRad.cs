using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatRad : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector3 startRoad;
    // private float repeatBackground;
    void Start()
    {
        startRoad =transform.position;
        // repeatBackground = GetComponent<BoxCollider>().size.z /2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < startRoad.x -25 )
        {
            transform.position = startRoad;
        }
       
    }
    
}
