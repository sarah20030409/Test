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
        SwitchInAnim.SetBool("WhiteOff",true); //WhiteOff是透明度動畫的名稱(影響透明度不影響色相)，因為另一個場景也用這支，所以名字我安全起見先不更改，你直接用就好。
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
