using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenVerse : MonoBehaviour
{
    public Animator BlackSprite;

    public GameObject OpenTitleSence;
    public GameObject YangKuiSence;

    public GameObject TitleI;
    public GameObject TitleII;
    public GameObject TitleIII;
    public GameObject TitleIV;

    public float SwitchTime = 0f;
    float AnimTime = 2f;

    void Start()
    {
        StartCoroutine(TitleSwitch());
    }

    void Update()
    {
        
    }

    private IEnumerator TitleSwitch() { 
        yield return new
        WaitForSeconds(1.0f);
        BlackSprite.SetBool("TitleOn",true);

        // 1
        yield return new
        WaitForSeconds(AnimTime);
        TitleI.SetActive(true);
        BlackSprite.SetBool("TitleOn", false);

        yield return new
        WaitForSeconds(SwitchTime);
        BlackSprite.SetBool("TitleOn", true);

        // 2
        yield return new
        WaitForSeconds(AnimTime);
        TitleI.SetActive(false);
        TitleII.SetActive(true);
        BlackSprite.SetBool("TitleOn", false);

        yield return new
        WaitForSeconds(SwitchTime);
        BlackSprite.SetBool("TitleOn", true);

        // 3
        yield return new
        WaitForSeconds(AnimTime);
        TitleII.SetActive(false);
        TitleIII.SetActive(true);
        BlackSprite.SetBool("TitleOn", false);

        yield return new
        WaitForSeconds(SwitchTime);
        BlackSprite.SetBool("TitleOn", true);

        // 4
        yield return new
        WaitForSeconds(AnimTime);
        TitleIII.SetActive(false);
        TitleIV.SetActive(true);
        BlackSprite.SetBool("TitleOn", false);

        yield return new
        WaitForSeconds(SwitchTime);
        BlackSprite.SetBool("TitleOn", true);

        yield return new
        WaitForSeconds(AnimTime);
        BlackSprite.SetBool("TitleOn", false);
        OpenTitleSence.SetActive(false);
        YangKuiSence.SetActive(true);

    }
}
