using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Zadanie_5 : MonoBehaviour
{
    public GameObject cube;

    private List<Vector3> usedPositions = new List<Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        List<int> pozycje_x = new List<int>(Enumerable.Range(0, 20).OrderBy(x => Guid.NewGuid()).Take(10));
        List<int> pozycje_z = new List<int>(Enumerable.Range(0, 20).OrderBy(x => Guid.NewGuid()).Take(10));

        for (int i = 0; i<10; i++){
            Instantiate(cube, new Vector3(pozycje_x[i], 0.5f, pozycje_z[i]), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
