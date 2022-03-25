using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float speed = 32;
    // Update is called once per frame
    void Update()
    {
    Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
    //print(input);
    Vector3 direction= input.normalized;    
    Vector3 velocity = direction * speed; 
    Vector3 moveAmmount = velocity * Time.deltaTime; 
    //transform.position += moveAmmount;
    transform.Translate(moveAmmount);
    
    }
}
