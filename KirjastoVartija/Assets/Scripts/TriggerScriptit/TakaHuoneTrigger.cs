using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakaHuoneTrigger : MonoBehaviour
{
    private bool Vaatteetvaihdettu = false;
    private bool sisässä = false;
    public GameObject TarkistaTilat;
    private void OnTriggerEnter(Collider other) {
        sisässä = true;
    }

    private void OnTriggerExit(Collider other) {
        sisässä = false;
    }

    void Update() {
        if (sisässä && Input.GetKeyDown(KeyCode.E)) {
            Vaatteetvaihdettu = true;
            Debug.Log(Vaatteetvaihdettu);
            TarkistaTilat.SetActive(true);
        }
    }
}
