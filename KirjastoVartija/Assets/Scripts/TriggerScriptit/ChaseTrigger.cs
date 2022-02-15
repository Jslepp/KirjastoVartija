using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseTrigger : MonoBehaviour
{
    private bool ChaseAlkaa = false;
    private void OnTriggerEnter(Collider other) {
        ChaseAlkaa = true;
    }
}
