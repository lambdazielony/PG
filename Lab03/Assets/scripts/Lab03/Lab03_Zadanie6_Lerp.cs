using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab03_Zadanie6_Lerp : MonoBehaviour
{
    public Transform target;   
    public Transform follower; 
    public float lerpSpeed = 5.0f;  

    void Update()
    {
        follower.position = Vector3.Lerp(follower.position, target.position, lerpSpeed * Time.deltaTime);
        
    }
}
