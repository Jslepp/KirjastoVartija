using UnityEngine;
using UnityEngine.UI;

public class ObjectiveTrigger : MonoBehaviour
{
    public Text teksti;
    public Animator anim;

    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        anim.Play("TextFadeOut");
    }
    private void OnTriggerExit(Collider other) 
    {
        
    }
}