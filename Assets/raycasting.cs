using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycasting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Physics.Raycast (transform.position, transform.forward, 100)){
           Debug.Log ("colide");
           Debug.DrawRay(transform.position, transform.forward, Color.green, 100);
        }
        else Debug.Log ("não colide");




    }
}
