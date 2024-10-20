using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie_2 : MonoBehaviour
{

    public float speed = 1.0f;
    private float distance = 10.0f;
    private Vector3 startPos;

    private bool forward = true;

    // Start is called before the first frame update
    void Start()
    {
          startPos = transform.position;      
    }

    // Update is called once per frame
    void Update()
    {
        if(forward){
            transform.position += Vector3.right * speed * Time.deltaTime;
            if(transform.position.x >= startPos.x+distance){
                forward = false;
            }
        } else {
            transform.position -= Vector3.right * speed * Time.deltaTime;
            if(transform.position.x < startPos.x){
                forward = true;
            }
        }            
    }
}
