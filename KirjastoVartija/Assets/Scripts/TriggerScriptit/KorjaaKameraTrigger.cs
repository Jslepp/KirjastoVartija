using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KorjaaKameraTrigger : MonoBehaviour
{
    public GameObject parent;
    private bool KameraKorjattu = false;
    private bool sisässä = false;
    private void OnTriggerEnter(Collider other) {
        sisässä = true;
    }

    private void OnTriggerExit(Collider other) {
        sisässä = false;
    }

    void Update() {
        if (sisässä && Input.GetKeyDown(KeyCode.E)) {
            KameraKorjattu = true;
            parent.SetActive(false);
        }
    }
}
