using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_Point : MonoBehaviour
{
    public GameObject BlackAnim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(SswitchSence());
        }
    }

    public IEnumerator SswitchSence() {
        yield return new
        WaitForSeconds(1f);
        BlackAnim.SetActive(true);

        yield return new
        WaitForSeconds(3.0f);
        ChangeSceneFunction.ChangeScenes("EP1_2");
    }
}
