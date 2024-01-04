using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaiTitle : MonoBehaviour
{
    public GameObject CaiTitleScene;
    public GameObject BlockHouseScene;

    public GameObject LightDot;

    public Animator LightDotAnim;

    public float TitleDurationTime = 0f;
    void Start()
    {
        StartCoroutine(CaiTScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator CaiTScene() {
        yield return new
        WaitForSeconds(1.0f);
        LightDotAnim.SetBool("DLAnim1", false);

        yield return new
        WaitForSeconds(TitleDurationTime);
        LightDotAnim.SetBool("DLAnim2", true);

        yield return new
        WaitForSeconds(1.0f);
        BlockHouseScene.SetActive(true);

        yield return new
        WaitForSeconds(10.0f);
        CaiTitleScene.SetActive(false);
        LightDot.SetActive(false);

    }
}
