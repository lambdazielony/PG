using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie_3 : MonoBehaviour
{

    public float speed = 1.0f;
    private float distance = 10.0f;

    private int currentDir = 0;
    private float distanceWalked = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
 
        distanceWalked += speed * Time.deltaTime;
        if(currentDir == 0){
            transform.position += Vector3.forward * speed * Time.deltaTime;
            if(distanceWalked >= distance){
                distanceWalked = 0.0f;
                transform.Rotate(0, 90, 0);
                currentDir = 1;
            }
        } else if(currentDir == 1){
            transform.position += Vector3.right * speed * Time.deltaTime;
            if(distanceWalked >= distance){
                distanceWalked = 0.0f;
                transform.Rotate(0, 90, 0);
                currentDir = 2;
            }
        } else if(currentDir == 2){
            transform.position += Vector3.back * speed * Time.deltaTime;
            if(distanceWalked >= distance){
                distanceWalked = 0.0f;
                transform.Rotate(0, 90, 0);
                currentDir = 3;
            }
        } else if (currentDir == 3){
            transform.position += Vector3.left * speed * Time.deltaTime;
            if(distanceWalked >= distance){
                distanceWalked = 0.0f;
                transform.Rotate(0, 90, 0);
                currentDir = 0;
            }
        }

    }
}

