using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilatTarkistettu : MonoBehaviour
{
    public GameObject tila;
    public GameObject tila1;
    public GameObject tila2;
    public GameObject tila3;
    
    // Update is called once per frame
    void Update()
    {
        if (tila.activeSelf == false && tila1.activeSelf == false && tila2.activeSelf == false && tila3.activeSelf == false) {
            Debug.Log("Tilat tarkistettu");
            this.gameObject.SetActive(false);
        }
    }
}
