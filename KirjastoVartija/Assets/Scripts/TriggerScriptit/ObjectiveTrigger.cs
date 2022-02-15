using UnityEngine;
using UnityEngine.UI;

public class ObjectiveTrigger : MonoBehaviour
{
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
            kamerat[i-1].SetActive(!kamerat[i-1].activeSelf);
            Näyttö.GetComponent<MeshRenderer>().material = material[4];
        }
        if (i == 0) {
            kamerat[3].SetActive(false);
            Näyttö.GetComponent<MeshRenderer>().material = material[4];
        }
    }


    void Update() 
    {
        if (OnTriggerstay && Input.GetKeyDown(KeyCode.E)) {
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