using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoistuJosAvaimet : MonoBehaviour
{
    private bool OnkoAvaimet = false;
    private bool sisässä = false;
    private void OnTriggerEnter(Collider other) {
        sisässä = true;
    }

    private void OnTriggerExit(Collider other) {
        sisässä = false;
    }

    void Update() {
        if (sisässä && Input.GetKeyDown(KeyCode.E) && OnkoAvaimet) {
            // Pääset pois
        }
    }
}
