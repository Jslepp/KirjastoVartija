using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NostaKirjaTrigger : MonoBehaviour
{
    private bool KirjaNostettu = false;
    private bool sisässä = false;
    private void OnTriggerEnter(Collider other) {
        sisässä = true;
    }

    private void OnTriggerExit(Collider other) {
        sisässä = false;
    }

    void Update() {
        if (sisässä && Input.GetKeyDown(KeyCode.E)) {
            KirjaNostettu = true;
        }
    }
}
