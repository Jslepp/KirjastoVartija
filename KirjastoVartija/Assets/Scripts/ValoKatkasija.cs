using UnityEngine;
using UnityEngine.UI;

public class ValoKatkasija : MonoBehaviour
{
    public Text teksti;
    public Animator anim;
    public bool OnTriggerstay = false; 

    public GameObject katkasinylhäällä;
    public GameObject katkasinalhaalla;
    public GameObject valot;


    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        OnTriggerstay = true;
        anim.Play("TextFadeOut");
        teksti.text = "Press [E] to turn on/off the lights";
        anim.Play("TextFadeIn");
    }
    private void OnTriggerExit(Collider other) 
    {
        OnTriggerstay = false;
    }


    void Update() 
    {
        
        if (OnTriggerstay && Input.GetKeyDown(KeyCode.E)) {
            valot.SetActive(!valot.activeSelf);
            if (valot.activeSelf) {
                katkasinylhäällä.SetActive(false);
                katkasinalhaalla.SetActive(true);
            }
            if (valot.activeSelf == false) {
                katkasinylhäällä.SetActive(true);
                katkasinalhaalla.SetActive(false);
            }
        }
    }
}