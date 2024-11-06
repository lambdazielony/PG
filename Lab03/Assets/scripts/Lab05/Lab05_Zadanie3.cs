using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab05_Zadanie3 : MonoBehaviour
{
    public List<Vector3> positions = new List<Vector3>(); 
    public float speed = 25f;

    private int i = 0; 
    private bool forward = true; 

    void Update()
    {

        //do sprawdzenia, czy są jakięs elementy w liscie 
        if (positions.Count == 0) return;

        Vector3 targetPosition = positions[i];

        //ruch plaftormy zgodnie z daną pozycja z listy
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        //jezeli dotarto do pozycji, to ustaw kolejną 
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            if (forward){
                i++;
                if (i >= positions.Count){
                    i = positions.Count - 2; // -2 bo wcześniej zrobiliśmy i++ i aby wrócić o jedną pozycje, to trzeba odjąć 2
                    forward = false; // zmieniamy kierunek ruchu na wsteczny
                }
            }
            else {
                i--;
                if (i < 0){
                    i = 1; 
                    forward = true; 
                }
            }
        }
    }
}
