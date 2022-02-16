using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TarkistaTilatTrigger : MonoBehaviour
{
    private bool hoidettu = false;
    private void OnTriggerEnter(Collider other) {
        hoidettu = true;
        this.gameObject.SetActive(false);
    }
}
