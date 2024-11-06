using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab05_Zadanie2 : MonoBehaviour 
{
    public float doorSpeed = 2f;
    private bool isRunning = false;
    public float distance = 10f;
    private bool isOpening = true;
    private bool isClosing = false;
    private float closedPosition; //wcześniej down
    private float openPosition;

    private Transform oldParent;

    void Start()
    {
        openPosition = transform.position.x + distance;
        closedPosition = transform.position.x;
    }

    void Update()
    {
        if (isOpening && transform.position.x >= openPosition) {
            isRunning = false;
        }
        else if (isClosing && transform.position.x <= closedPosition) {
            isRunning = false;
        }

        if (isRunning) {
            Vector3 move = transform.right * doorSpeed * Time.deltaTime;
            transform.Translate(move);
        }
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {
            Debug.Log("Player jest przy drzwiach ");
           
            if (transform.position.x <= openPosition) {
                isOpening = true;
                isClosing = false;
                doorSpeed = Mathf.Abs(doorSpeed);
            }
            isRunning = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {
            Debug.Log("Player odszedł od drzwi.");
            if (transform.position.x >= closedPosition) {
                isOpening = false;
                isClosing = true;
                doorSpeed = -doorSpeed;
            }
            isRunning = true;
        }
    }
}