using UnityEngine;
using UnityEngine.UI;

public class ObjectiveTrigger : MonoBehaviour
{
    public GameObject korjaaKamera;
    private bool valotvälkkynyt = false;
    private int kameratkatsottu;
    private bool kamerakorjattu;
    public Text teksti;
    public Animator anim;
    public bool OnTriggerstay = false; 
    public GameObject[] kamerat;
    private int i = 0;

    public GameObject Näyttö;

    public Material[] material;

    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        OnTriggerstay = true;
        anim.Play("TextFadeOut");
        teksti.text = "Press E to use the cameras";
        anim.Play("TextFadeIn");
    }
    private void OnTriggerExit(Collider other) 
    {
        OnTriggerstay = false;
        if (i != 0) {
            kamerat[i-1].SetActive(false);
            Näyttö.GetComponent<MeshRenderer>().material = material[4];
        }
        if (i == 0) {
            kamerat[3].SetActive(false);
            Näyttö.GetComponent<MeshRenderer>().material = material[4];
        }
    }


    void Update() 
    {    

        if (valotvälkkynyt == true && korjaaKamera.activeSelf == false && kamerakorjattu == false) {
            kamerakorjattu = true;
            Debug.Log("Kamerakorjattu");
        }

        if (OnTriggerstay && Input.GetKeyDown(KeyCode.E) && valotvälkkynyt == false && kameratkatsottu <= 4) {
            if (i != 0) {
                kamerat[i-1].SetActive(false);
            }
            if (i == 0) {
                kamerat[3].SetActive(false);
            }
            kamerat[i].SetActive(!kamerat[i].activeSelf);
            Näyttö.GetComponent<MeshRenderer>().material = material[i];
            i = i + 1;
            if (i == 4) {
                i = 0;
            }
            kameratkatsottu = kameratkatsottu + 1;
        }

        if (kameratkatsottu == 4 && valotvälkkynyt == false) {
            Debug.Log("Valo välkky");
            korjaaKamera.SetActive(true);
            // TODO valotvälkkyy metodi
            valotvälkkynyt = true;
        }

        if (OnTriggerstay && Input.GetKeyDown(KeyCode.E) && valotvälkkynyt == true && kamerakorjattu == false) {
            Debug.Log("Kamera ei toimi");
            if (i != 0) {
                kamerat[i-1].SetActive(false);
            }
            if (i == 0) {
                kamerat[3].SetActive(false);
            }
            if (i == 2) {
                Näyttö.GetComponent<MeshRenderer>().material = material[4];
            }
            if (i != 2) {
                kamerat[i].SetActive(!kamerat[i].activeSelf);
                Näyttö.GetComponent<MeshRenderer>().material = material[i];
            }
            i = i + 1;
            if (i == 4) {
                i = 0;
            }
        }
        
        if (OnTriggerstay && Input.GetKeyDown(KeyCode.E) && valotvälkkynyt == true && kamerakorjattu == true) {
            Debug.Log("Kamera toimii");
            if (i != 0) {
                kamerat[i-1].SetActive(false);
            }
            if (i == 0) {
                kamerat[3].SetActive(false);
            }
            kamerat[i].SetActive(!kamerat[i].activeSelf);
            Näyttö.GetComponent<MeshRenderer>().material = material[i];
            i = i + 1;
            if (i == 4) {
                i = 0;
            }
        }
        
    }
}