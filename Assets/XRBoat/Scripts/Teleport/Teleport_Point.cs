using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_Point : MonoBehaviour
{
    public GameObject BlackAnim;
    public Animator SwitchInAnim;
    public string Distination;

    private void Start()
    {
        SwitchInAnim.SetBool("WhiteOff",true); 
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(SwitchSence());
        }
    }

    public IEnumerator SwitchSence() {
        yield return new
        WaitForSeconds(1f);
        BlackAnim.SetActive(true);

        yield return new
        WaitForSeconds(3.0f);
        ChangeSceneFunction.ChangeScenes(Distination);
    }
}
