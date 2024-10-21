using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class Lab04_Zadanie_1 : MonoBehaviour
{
 List<Vector3> positions = new List<Vector3>();
    
    public float delay = 3.0f;
    public int noObejctsToGenerate = 10;

    public Material[] materials = new Material[5]; //materiały podpięte w interfejsie Unity
    int objectCounter = 0;
    
    // obiekt do generowania
    public GameObject block;

    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        Bounds bounds = renderer.bounds;

        // Wymiary platformy
        float minX = bounds.min.x;
        float maxX = bounds.max.x;
        float minZ = bounds.min.z;
        float maxZ = bounds.max.z;

        // w momecie uruchomienia generuje 10 kostek w losowych miejscach
        //List<int> pozycje_x = new List<int>(Enumerable.Range((int)minX, (int)maxX).Select(x => UnityEngine.Random.Range(minX, maxX)).Take(noObejctsToGenerate));
        //List<int> pozycje_z = new List<int>(Enumerable.Range((int)minZ, (int)maxZ).OrderBy(x => Guid.NewGuid()).Take(noObejctsToGenerate));
        
        List<float> pozycje_x = new List<float>(Enumerable.Range(0, noObejctsToGenerate*2).Select(x => UnityEngine.Random.Range(minX, maxX)).Take(noObejctsToGenerate));
        List<float> pozycje_z = new List<float>(Enumerable.Range(0, noObejctsToGenerate*2).Select(x => UnityEngine.Random.Range(minZ, maxZ)).Take(noObejctsToGenerate));

        for(int i=0; i<noObejctsToGenerate; i++)
        {
            this.positions.Add(new Vector3(pozycje_x[i], 5, pozycje_z[i]));
        }
        foreach(Vector3 elem in positions){
            Debug.Log(elem);
        }
        // uruchamiamy coroutine
        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {
        
    }

    IEnumerator GenerujObiekt()
    {
        Debug.Log("wywołano coroutine");
        foreach(Vector3 pos in positions)
        {
            Material chosenMaterial = materials[UnityEngine.Random.Range(0, 5)];
            GameObject newBlock = Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            Renderer blockRenderer = newBlock.GetComponent<Renderer>();
            blockRenderer.material = chosenMaterial;
            yield return new WaitForSeconds(this.delay);
        }
        // zatrzymujemy coroutine
        StopCoroutine(GenerujObiekt());
    }
}
