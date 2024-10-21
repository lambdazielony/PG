using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab03_Zadanie6_Smooth : MonoBehaviour
{
   
    public Transform target; 
    public Transform follower;

    // Parametry SmoothDamp
    public float smoothTime = 0.5f;  
    private Vector3 velocity = Vector3.zero;  

    void Update()
    {
        
        follower.position = Vector3.SmoothDamp(follower.position, target.position, ref velocity, smoothTime);
    }
}
