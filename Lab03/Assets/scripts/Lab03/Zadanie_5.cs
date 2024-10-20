using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie_5 : MonoBehaviour
{
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i<=10; i++){
            Instantiate(cube, randomPos(), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 randomPos(){
        float x = Random.Range(-5.0f, 5.0f);
        float z = Random.Range(-305.0f, -295.0f);
        Vector3 randomPosition = new Vector3(x, 0.5f, z);
        return randomPosition;
    }
}
