using UnityEngine;
using UnityEngine.UI;

public class ObjectiveTrigger : MonoBehaviour
{
    public Text teksti;
    public Animator anim;
    public GameObject gameobject;

    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        teksti.text = "Press [Space] to turn on/off the lights";
    }
    private void OnTriggerExit(Collider other) 
    {
        
    }

    private void OnTriggerStay(Collider other) 
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Space");
            gameobject.SetActive(!gameobject.activeSelf);
        }
    }
}