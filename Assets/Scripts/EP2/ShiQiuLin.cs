using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShiQiuLin : MonoBehaviour
{
    public GameObject SpotLight;

    public Animator SpotLightOn;
    public Animator DotLightAnim;

    public float DurationTime = 0f;

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
        SpotLightOn.SetBool("LightOn",true);

        yield return new
        WaitForSeconds(0.2f);
        SpotLight.SetActive(true);

        yield return new
        WaitForSeconds(DurationTime);
        //DotLightAnim.SetBool();


    }
}
