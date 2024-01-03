using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleII : MonoBehaviour
{
    public GameObject ShiQiuLinSence;
    public GameObject TitleIISence;
    public GameObject TitleImg;

    public Animator BlackAnim;

    public float TitleDurationTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TitleIIOn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator TitleIIOn() {
        yield return new
        WaitForSeconds(1.0f);
        TitleImg.SetActive(false);
        BlackAnim.SetBool("TitleOn",true);

        yield return new
        WaitForSeconds(1.5f);
        TitleImg.SetActive(true);
        BlackAnim.SetBool("TitleOn", false);

        yield return new
        WaitForSeconds(TitleDurationTime);
        BlackAnim.SetBool("TitleOn",true);

        yield return new
        WaitForSeconds(1.5f);
        TitleImg.SetActive(false);

        yield return new
        WaitForSeconds(2.0f);
        TitleIISence.SetActive(false);
        ShiQiuLinSence.SetActive(true);

    }
}
