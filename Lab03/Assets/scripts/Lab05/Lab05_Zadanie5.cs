using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab05_Zadanie5 : MonoBehaviour {
    public float launchForce = 3f;

    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){

            //odniesienie do skryptu ruchu gracza
            MoveWithCharacterController playerController = other.GetComponent<MoveWithCharacterController>();

            if (playerController != null){
                //wywołanie metody z skrypty gracza
                playerController.LaunchPlayer(launchForce);
            }
        }
    }
}