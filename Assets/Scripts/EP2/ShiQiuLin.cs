using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShiQiuLin : MonoBehaviour
{
    public GameObject SpotLight;
    public GameObject DotLight;
    public GameObject SuicideScene;

    public Animator SpotLightOn;
    public Animator DotLightAnim;

    public float DurationTime = 0f;
    public float OpenSuicideScene = 0f;
    private float CloseSpotLight = 15f;

    void Start()
    {
        StartCoroutine(SQLSnece());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SQLSnece() {
        yield return new
        WaitForSeconds(2.0f);
        DotLight.SetActive(false);

        yield return new
        WaitForSeconds(0.2f);
        SpotLight.SetActive(true);
        SpotLightOn.SetBool("LightOn", true);

        yield return new
        WaitForSeconds(DurationTime);
        DotLight.SetActive(true);
        DotLightAnim.SetBool("DLAnim1",true);

        yield return new
        WaitForSeconds(CloseSpotLight);
        SpotLightOn.SetBool("LightOff", true);
        SpotLightOn.SetBool("LightOn", false);

        yield return new 
        WaitForSeconds(OpenSuicideScene - CloseSpotLight);
        SuicideScene.SetActive(true);
        SpotLightOn.SetBool("LightOff", false);

    }
}
