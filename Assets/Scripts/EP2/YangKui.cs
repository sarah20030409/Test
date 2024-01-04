using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YangKui : MonoBehaviour
{
    public GameObject EyeGroup;
    public GameObject YangKuiSence;
    public GameObject TitleIISence;
    public GameObject Mirror;
    public GameObject SpotLight;

    public Animator SpotLightOn;
    public Animator YangKuiRunAwayAnim;
    public Animator WaveDownAnim;

    public float YangKuiRunTime = 0f;

    void Start()
    {
        StartCoroutine(YKRunning());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator YKRunning() {
        yield return new
        WaitForSeconds(0.5f);
        EyeGroup.SetActive(false);
        Mirror.SetActive(false);


        yield return new
        WaitForSeconds(2.0f);
        SpotLightOn.SetBool("LightOn",true);
        Mirror.SetActive(true);

        yield return new
        WaitForSeconds(YangKuiRunTime);
        WaveDownAnim.SetBool("WaveDown",true);

        yield return new
        WaitForSeconds(1.0f);
        YangKuiRunAwayAnim.SetBool("RunAway",true);
        SpotLightOn.SetBool("LightOn", false);

        yield return new 
        WaitForSeconds(1.0f);
        SpotLightOn.SetBool("LightOff", true);

        yield return new 
        WaitForSeconds(2.0f);
        YangKuiSence.SetActive(false);
        TitleIISence.SetActive(true);
        Mirror.SetActive(false);
        SpotLight.SetActive(false);


    }
}
