using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeitäKahviTrigger : MonoBehaviour
{
    private bool KeitäKahvi = false;
    private bool sisässä = false;
    private void OnTriggerEnter(Collider other) {
        sisässä = true;
    }

    private void OnTriggerExit(Collider other) {
        sisässä = false;
    }

    void Update() {
        if (sisässä && Input.GetKeyDown(KeyCode.E)) {
            KeitäKahvi = true;
        }
    }
}
